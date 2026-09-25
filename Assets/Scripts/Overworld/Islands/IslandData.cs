using UnityEngine;

public enum IslandType
{
    Desert,
    Jungle,
    Settlement,
    Fort,
    Shipwreck
}

[CreateAssetMenu(fileName = "IslandData", menuName = "Scriptable Objects/Islands/IslandData")]
public class IslandData : ScriptableObject
{
    [SerializeField] private IslandType type;
    //[SerializeField] private GameObject _islandPrefab; TODO swap for model to avoid cyclical reference in prefab
    [SerializeField] private string sceneToLoad;

    public IslandType Type => type;
    //public GameObject IslandPrefab => _islandPrefab;
    public string SceneToLoad => sceneToLoad;
}
