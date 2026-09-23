using System;
using Unity.VectorGraphics;
using UnityEngine;

public enum IslandType
{
    Desert,
    Jungle,
    Settlement,
    Fort
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
}
