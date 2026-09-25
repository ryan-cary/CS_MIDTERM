using UnityEngine;

public class OverworldTile : MonoBehaviour
{
    [SerializeField] private Island island;
    [SerializeField] private float width = 50f; //width of one side in m
    
    private Transform _islandPosition; //transform relative to origin of tile to place island
    
    void Start()
    {
        //generate random transform within tile area
        // --> padding for Island width to avoid overlap into other tiles
        //position Island at transform
    }
}
