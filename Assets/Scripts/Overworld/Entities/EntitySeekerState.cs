using UnityEngine;

public class EntitySeekerState : EntityState
{
    private float _distanceToPlayer;
    
    public EntitySeekerState(OverworldEntity entity) : base(entity)
    { }


    public override void OnStateEnter()
    { Debug.Log("Entity entered seeking state!"); }

    public override void OnStateUpdate()
    {
        if (_entity.player != null)
            _distanceToPlayer = Vector3.Distance(_entity.transform.position, _entity.player.position);

        if (ShouldTransitionToPassive())
            TransitionToPassive();
        
        if (ShouldTransitionToAction())
            TransitionToAction();
    }

    public override void OnStateExit()
    { }
    
    private void Follow()
    { _entity.agent.SetDestination(_entity.player.position); }

    private bool ShouldTransitionToPassive()
    { return _entity.player == null || _distanceToPlayer > 55; }

    private bool ShouldTransitionToAction()
    { return _distanceToPlayer <= 10; }

    private void TransitionToPassive()
    { _entity.ChangeState(new EntityPassiveState(_entity)); }

    private void TransitionToAction()
    { _entity.ChangeState(new EntityActionState(_entity)); }
}
