using UnityEngine;

[CreateAssetMenu(fileName = "Transaction", menuName = "Scriptable Objects/Transaction")]
public class Transaction : ScriptableObject
{
    [Header("Merchant Wants")]
    [SerializeField] private LootType sellType;
    [SerializeField] private int sellAmount;
    
    [Header("Merchant Offers")]
    [SerializeField] private LootType buyType;
    [SerializeField] private int buyAmount;

    public LootType SellType => sellType;
    public int SellAmount => sellAmount;

    public LootType BuyType => buyType;
    public int BuyAmount => buyAmount;

    public string GetTransactionText()
    {
        return $"Trade {sellAmount} {sellType.ToString()} for {buyAmount} {buyType.ToString()}";
    }
    
    
}
