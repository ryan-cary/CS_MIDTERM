using System;
using UnityEngine;

[Serializable]
public enum LootType
{
    Gold,
    Grog,
    Repair,
    Cannonball,
    Cannon
}

[CreateAssetMenu(fileName = "LootItem", menuName = "Scriptable Objects/Loot Tables/LootItem")]
public class LootItem : ScriptableObject
{
    public LootType type = LootType.Gold;
    //public int weight = 1;
    public int amount = 1;
}
