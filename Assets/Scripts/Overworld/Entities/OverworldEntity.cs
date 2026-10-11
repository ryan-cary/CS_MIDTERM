using System;
using UnityEngine;
using UnityEngine.AI;

public class OverworldEntity : MonoBehaviour, IDamageable
{
    #region Action

    [SerializeField] private EntityAction action;

    public EntityAction Action => action;

    #endregion

    #region StateMachine

    private EntityState _currentState;

    [Header("Navigation")]
    public Transform entityEye;
    public float sightRadius;
    public float sightDistance;
    public NavMeshAgent agent;

    [HideInInspector] public Transform player;

    protected void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _currentState = new EntityPassiveState(this);
        _currentState.OnStateEnter();
    }

    protected void Update()
    { _currentState.OnStateUpdate(); }

    public void ChangeState(EntityState state)
    {
        _currentState.OnStateExit();
        _currentState = state;
        _currentState.OnStateEnter();
    }

    #endregion

    public virtual void TakeDamage(float damage)
    {
        // This is just a placeholder since I haven't implemented entity health / a real combat system yet
        ChangeState(new EntityDeathState(this));
    }
    
}
