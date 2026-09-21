using Unity.VectorGraphics;
using UnityEngine;

public class Island : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad;

    public string GetIslandScene()
    {
        return _sceneToLoad;
    }
}
