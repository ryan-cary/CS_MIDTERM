using UnityEngine;

public abstract class EntityAction : MonoBehaviour
{
    protected OverworldEntity _entity;
    
    private float _timer;

    private void Start()
    {
        _entity = GetComponentInParent<OverworldEntity>();
    }
    
    public abstract void Execute();

    public bool IsOnCooldown()
    {
        _timer -= Time.deltaTime;
        
        if (_timer > 0)
        {
            return true;
        }

        return false;
    }

    public void StartCooldown(float cooldown)
    {
        _timer = cooldown;
    }
}
