using System.Collections.Generic;
using UnityEngine;

public class OverworldTile : MonoBehaviour
{
    [Header("Island Parameters")]
    [SerializeField] private int maxNumIslands = 5;
    [SerializeField] private float minRadius = 200;
    [SerializeField] private float maxRadius = 600;
    
    private IslandFactory _islandFactory;

    [Header("Entity Parameters")] 
    [SerializeField] private int maxNumEntities = 2;
    [SerializeField] private int numEntitiesOffset;
    [SerializeField] private float spawnRadius = 400;

    private EntityFactory _entityFactory;
    
    void Start()
    {
        _islandFactory = FindFirstObjectByType<IslandFactory>();
        _entityFactory = FindFirstObjectByType<EntityFactory>();
        
        int numIslands = Random.Range(0, maxNumIslands+1);
        GenerateIslands();
        GenerateEntities();
    }

    private void GenerateIslands()
    {
        int numIslands = Random.Range(0, maxNumIslands+1);
        
        for (int i = 0; i < numIslands; i++)
        {
            float radians = 2 * Mathf.PI / numIslands * i;

            Vector3 direction = new Vector3(Mathf.Sin(radians), 0, Mathf.Cos(radians));

            Vector3 position = gameObject.transform.position + direction * Random.Range(minRadius, maxRadius);

            Instantiate(_islandFactory.RandomIsland(), position, Quaternion.identity);
        }
    }

    private void GenerateEntities()
    {
        int numEntities = Random.Range(0, maxNumEntities + 1); 
        
        for (int i = 0; i < numEntities; i++)
        {
            Vector3 position = Random.insideUnitCircle * Random.Range(0, spawnRadius);

            Instantiate(_entityFactory.RandomEntity(), position, Quaternion.identity);
        }
    }
}
