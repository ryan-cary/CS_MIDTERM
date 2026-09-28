using UnityEngine;
using UnityEngine.AI;

public class OverworldEntity : MonoBehaviour
{
    private EntityState _currentState;

    [SerializeField] private EntityAction action;

    public Transform entityEye;
    public float sightRadius;
    public float sightDistance;
    public NavMeshAgent agent;

    [HideInInspector] public Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _currentState = new EntityPassiveState(this);
        _currentState.OnStateEnter();
    }

    void Update()
    { _currentState.OnStateUpdate(); }

    public void ChangeState(EntityState state)
    {
        _currentState.OnStateExit();
        _currentState = state;
        _currentState.OnStateEnter();
    }
}
