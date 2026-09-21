using Unity.VectorGraphics;
using UnityEngine;

public class Island : MonoBehaviour
{
    [SerializeField] private Scene _sceneToLoad;

    public Scene GetIslandScene()
    {
        return _sceneToLoad;
    }
}
