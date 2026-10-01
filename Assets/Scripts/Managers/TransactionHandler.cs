using UnityEngine;

public static class TransactionHandler
{
    public static void DoTransaction(LootType sellType, int sellAmount, LootType buyType, int buyAmount)
    {
        PlayerInventory inv = GameManager.GetInstance().GetPlayer().Inventory;  
    }
}
