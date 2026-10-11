using UnityEngine;

public class EntityGrapplingState : EntityActionState
{
    private IGrappler _grappler;
    
    public EntityGrapplingState(OverworldEntity entity) : base(entity)
    { }

    public override void OnStateEnter()
    {
        _grappler = _entity.GetComponent<IGrappler>();
        _grappler.Attach();
    }

    public override void OnStateUpdate()
    {
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
}
