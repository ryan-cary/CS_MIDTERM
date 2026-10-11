using UnityEngine;

public abstract class EntityAction : MonoBehaviour
{
    public float damage;
    public float cooldown;
    private float _timer;
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
}
