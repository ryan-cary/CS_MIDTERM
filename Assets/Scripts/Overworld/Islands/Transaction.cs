using UnityEngine;

[CreateAssetMenu(fileName = "Transaction", menuName = "Scriptable Objects/Transaction")]
public class Transaction
{
    public LootType typeToSell;
    public LootType typeToBuy;
    public int sellAmount;
    public int buyAmount;
}
