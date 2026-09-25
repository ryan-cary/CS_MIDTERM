using UnityEngine;

public class OverworldTile : MonoBehaviour
{
    [SerializeField] private Island island;
    [SerializeField] private float width = 50f; //width of one side in m
    
    private Transform _islandPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //generate random transform within tile area
        // --> padding for Island width to avoid overlap into other tiles
        //position Island at transform
    }
}
