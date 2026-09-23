using UnityEngine;

[CreateAssetMenu(fileName = "LootTable", menuName = "Scriptable Objects/Loot Tables/Loot Table")]
public class LootTableData : ScriptableObject
{
    public int tableSize = 128;

    public LootTableEntry[] loot;

}
