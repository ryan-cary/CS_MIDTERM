using UnityEngine;

public class WorldMap : MonoBehaviour
{
    [SerializeField] private int size = 9; //length in tiles of one side of world map

    public int Size => size;

    private OverworldTile[][] _tileMap;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        // ensure map has a center tile
        if (size % 2 == 0)
            size++;
        
        // populate map
        for (int i = 0; i < size; i++)
        {
            _tileMap[i] = new OverworldTile[size];
            for (int j = 0; j < size; j++)
            {
                _tileMap[i][j] = new OverworldTile();
            }
        }
    }
}
