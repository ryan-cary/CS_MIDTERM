using UnityEngine;

public class OverworldMap : MonoBehaviour
{
    [SerializeField] private int mapSize = 5;
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private float tileSize = 1250;
    
    void Awake()
    {
        GenerateMap();
    }

    void Start()
    {
        MovePlayerToCenter();
    }

    void GenerateMap()
    {
        for (int i = 0; i < mapSize; i++)
        {
            for (int j = 0; j < mapSize; j++)
            {
                Vector3 position = new Vector3(tileSize * i, 0, tileSize * j);
                Instantiate(tilePrefab, position, Quaternion.identity);
            }
        }
    }

    void MovePlayerToCenter()
    {
        float center = tileSize * (mapSize / 2);
        GameManager.Instance.GetPlayer().Ship.transform.position = new Vector3(center, 0, center);
    }
}
