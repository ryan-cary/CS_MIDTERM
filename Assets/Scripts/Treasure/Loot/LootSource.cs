using UnityEngine;

public class LootSource : MonoBehaviour
{
    [SerializeField] private LootItem treasure;
    
    public void GiveLoot()
    {
        switch (treasure.type)
        {
            case (LootType.Gold):
                GameManager.Instance.GetPlayer().Inventory.AddGold(treasure.amount);
                break;
            case (LootType.Grog):
                GameManager.Instance.GetPlayer().Inventory.AddGrog(treasure.amount);
                break;
            case (LootType.Cannonball):
                GameManager.Instance.GetPlayer().Inventory.AddCannonballs(treasure.amount);
                break;
            case (LootType.Repair):
                GameManager.Instance.GetPlayer().Ship.RepairDamage(treasure.amount);
                break;
            case (LootType.Cannon):
                Debug.Log("You have acquired another cannon!");
                break;
        } 
    }
}
