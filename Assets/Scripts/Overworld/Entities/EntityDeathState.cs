using System.Collections;
using UnityEngine;
using System;
using UnityEngine.AI;

public class EntityDeathState : EntityState
{
    private float DEBUG_deathSpeed = 25f;
    
    public EntityDeathState(OverworldEntity entity) : base(entity)
    { }

    public override void OnStateEnter()
    {
        MakeIntangible();
        _entity.StartCoroutine(DEBUG_DeathCoroutine());
    }

    public override void OnStateUpdate()
    {
        
    }

    public override void OnStateExit()
    { }

    private IEnumerator DEBUG_DeathCoroutine()
    {
        _entity.transform.Translate(Vector3.down * (DEBUG_deathSpeed * Time.deltaTime));
        yield return new WaitForSeconds(3);
        GameObject.Destroy(_entity.gameObject);
    }

    /// <summary>
    /// Disables collision and movement for the entity to prevent interaction with the player / rest of the overworld.
    /// </summary>
    private void MakeIntangible()
    {
        Collider c;
        NavMeshAgent agent;
        
        _entity.TryGetComponent<Collider>(out c);
        c.enabled = false;

        _entity.TryGetComponent<NavMeshAgent>(out agent);
        agent.enabled = false;
    }
}
