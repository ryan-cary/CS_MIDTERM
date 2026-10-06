using System.Collections.Generic;
using UnityEngine;

public class OverworldTile : MonoBehaviour
{
    [SerializeField] private int maxNumIslands = 5;
    [SerializeField] private float minRadius = 200;
    [SerializeField] private float maxRadius = 600;
    
    private IslandFactory _factory;

    //private List<GameObject> _islands;

    //public List<GameObject> IslandList => _islands;
    
    void Start()
    {
        _factory = FindFirstObjectByType<IslandFactory>();
        
        int numIslands = Random.Range(0, maxNumIslands+1);
        GenerateIslands(numIslands);
    }

    private void GenerateIslands(int numIslands)
    {
        for (int i = 0; i < numIslands; i++)
        {
            float radians = 2 * Mathf.PI / numIslands * i;

            Vector3 direction = new Vector3(Mathf.Sin(radians), 0, Mathf.Cos(radians));

            Vector3 positionVector = gameObject.transform.position + direction * Random.Range(minRadius, maxRadius);

            GameObject island = Instantiate(_factory.RandomIsland(), positionVector, Quaternion.identity);

            //_islands.Add(island);
        }
    }
}
