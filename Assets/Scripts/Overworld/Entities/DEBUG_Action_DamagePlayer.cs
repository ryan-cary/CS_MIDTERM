using UnityEngine;

public class DEBUG_Action_DamagePlayer : EntityAction
{
    public float damage = 10;
    public float cooldown = 5;
    
    public override void Execute()
    {
        Debug.Log($"Debug message: Entity {_entity} dealing {damage} damage with {cooldown} second cooldown");
        GameManager.Instance.GetPlayer().Ship.TakeDamage(damage);
        StartCooldown(cooldown);
    }
}
