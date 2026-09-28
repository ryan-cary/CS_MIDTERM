public abstract class EntityState
{
    protected OverworldEntity _entity;

    public EntityState(OverworldEntity entity)
    { _entity = entity; }

    public abstract void OnStateEnter();
    public abstract void OnStateUpdate();
    public abstract void OnStateExit();
}
