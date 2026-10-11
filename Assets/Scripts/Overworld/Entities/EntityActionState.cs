using UnityEngine;

public class EntityActionState : EntityState
{
    private float _distanceToPlayer;
    public EntityActionState(OverworldEntity entity) : base(entity)
    { }

    public override void OnStateEnter()
    {
        if (ShouldTransitionToGrapplingState())
            _entity.ChangeState(new EntityGrapplingState(_entity));
            
    }

    public override void OnStateUpdate()
    {
        if (_entity.player != null)
            _distanceToPlayer = Vector3.Distance(_entity.transform.position, _entity.player.position);
        
        if (ShouldTransitionToSeekerState())
            _entity.ChangeState(new EntitySeekerState(_entity));
        
        if (!_entity.Action.IsOnCooldown())
            _entity.Action.Execute();
    }

    public override void OnStateExit()
    {
        
    }

    private bool ShouldTransitionToGrapplingState()
    {
        return _entity.GetComponent<IGrappler>() != null;
    }

    protected bool ShouldTransitionToSeekerState()
    {
        return _distanceToPlayer > 10;
    }
}
