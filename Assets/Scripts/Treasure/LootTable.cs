using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "LootTable", menuName = "Scriptable Objects/Loot Tables/Loot Table")]
public class LootTable : ScriptableObject
{
    private Dictionary<LootType, float> _itemWeights;
    private Dictionary<LootType, int> _itemAmounts;
}
