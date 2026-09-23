using UnityEngine;

public abstract class OverworldEntity : MonoBehaviour
{
    [SerializeField] private EntityMovementBehavior _movementBehavior;
    [SerializeField] private EntityAction _entityAction;
    
    private float _curSpeed;
    
    public Transform target;

    private void Start()
    {
        
    }

    public virtual void DoAction()
    { _entityAction.Execute(); }
}
