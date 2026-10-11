using UnityEngine;

public class EntityGrapplingState : EntityState
{
    private IGrappler _grappler;
    private float _distanceToPlayer;
    
    public EntityGrapplingState(OverworldEntity entity) : base(entity)
    { }

    public override void OnStateEnter()
    {
        _grappler = _entity.GetComponent<IGrappler>();
        _grappler.Attach();
    }

    public override void OnStateUpdate()
    {
        if (_entity.player != null)
            _distanceToPlayer = Vector3.Distance(_entity.transform.position, _entity.player.position);
        
        // if somehow the grappler gets moved too far from the player, transition back to seeking
        if (ShouldTransitionToSeekerState())
            _entity.ChangeState(new EntitySeekerState(_entity));
        
        if (!_entity.Action.IsOnCooldown())
            _entity.Action.Execute();
    }

    public override void OnStateExit()
    {
        _grappler.Detach();
    }
    
    protected bool ShouldTransitionToSeekerState()
    {
        return _distanceToPlayer > 10;
    }
}
