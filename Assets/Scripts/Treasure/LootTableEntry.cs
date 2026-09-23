using UnityEngine;

[CreateAssetMenu(fileName = "LootTableEntry", menuName = "Scriptable Objects/Loot Tables/LootTableEntry")]
public class LootTableEntry : ScriptableObject
{
    public string lootName = "DEBUG_GenericLootName";
    public int weight = 0;
    public int amount = 1;
}
