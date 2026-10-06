using System.Collections.Generic;
using UnityEngine;

public class IslandFactory : MonoBehaviour
{
    /// <summary>
    /// I gotta say I don't fully understand what qualifies as a factory so this may not be it but this seemed like a
    /// good opportunity to use one. I think if I were actually creating new islands rather than instantiating prefabs
    /// it would be a true factory? 
    /// </summary>
    
    [SerializeField] private GameObject[] islandPrefabs;

    public GameObject RandomIsland()
    {
        int random = Random.Range(0, islandPrefabs.Length);

        return islandPrefabs[random];
    }
}
