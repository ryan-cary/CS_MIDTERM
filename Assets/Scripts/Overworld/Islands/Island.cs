using System;
using Unity.VectorGraphics;
using UnityEngine;

public class Island : MonoBehaviour
{
    [SerializeField] private IslandData _data;

    private bool _isCompleted;
    //[SerializeField] private string _ambientSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Load island scene of type {_data.Type}");
            SceneManager.Instance.Load(_data.SceneToLoad);
        }
    }

    private void MarkConquered()
    {
        Debug.Log("Display jolly roger on island");
    }
}
