using System;
using Unity.VectorGraphics;
using UnityEngine;

public class Island : MonoBehaviour
{
    [SerializeField] private IslandData data;
    [SerializeField] private Transform respawn; 

    private bool _isCompleted;
    //[SerializeField] private string _ambientSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GetSceneLoader().LoadIsland(data.SceneToLoad);
        }
    }

    private void MarkConquered()
    {
        Debug.Log("Display jolly roger on island");
    }

    public Transform GetRespawnTransform()
    {
        return respawn;
    }
}
