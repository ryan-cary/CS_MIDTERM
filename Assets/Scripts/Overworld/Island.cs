using System;
using Unity.VectorGraphics;
using UnityEngine;

public enum IslandType
{
    Desert,
    Jungle,
    Settlement,
    Fort,
    Shipwreck
}

public class Island : MonoBehaviour
{
    [SerializeField] private IslandType _type;
    [SerializeField] private GameObject _islandPrefab;
    [SerializeField] private string _sceneToLoad;
    [SerializeField] private string _ambientSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Load island scene {_sceneToLoad}");
        }
    }

    private void MarkAsLooted()
    {
        Debug.Log("Display a jolly roger for successful looting, or a white flag for failure");
    }
}
