using UnityEngine;
using UnityEngine.AI;

public class EntityPassiveState : EntityState
{
    private float _wanderRadius = 150f;
    private float _wanderTime = 8f;

    private float _timer;
    
    public EntityPassiveState(OverworldEntity entity) : base(entity)
    { }


    public override void OnStateEnter()
    { }

    public override void OnStateUpdate()
    {
        Wander();
        
        if (ShouldTransitionToSeeking())
            TransitionToSeeking();
    }

    public override void OnStateExit()
    {
        
    }

    public bool ShouldTransitionToSeeking()
    {
        if (Physics.SphereCast(_entity.entityEye.position, _entity.sightRadius, _entity.transform.forward,
                out RaycastHit info, _entity.sightDistance))
        {
            if (info.transform.CompareTag("Player"))
            {
                _entity.player = info.transform;
                return true;
            }
        }

        return false;
    }

    private void TransitionToSeeking()
    {
        _entity.agent.SetDestination(_entity.player.position);
        _entity.ChangeState(new EntitySeekerState(_entity));
    }
    
    private void Wander()
    {
        if (_timer >= _wanderTime) {
            Vector3 newPos = RandomNavSphere(_entity.transform.position, _wanderRadius, -1);
            _entity.agent.SetDestination(newPos);
            _timer = 0;
        }
        
        _timer += Time.deltaTime;
    }
    
    /// <summary>
    /// Finds a random point on the navmesh within a specified distance
    /// </summary>
    private Vector3 RandomNavSphere(Vector3 origin, float distance, int layermask) 
    {
        Vector3 direction = Random.insideUnitSphere * distance + origin;
        NavMesh.SamplePosition (direction, out NavMeshHit navHit, distance, layermask);

        return navHit.position;
    }
}
