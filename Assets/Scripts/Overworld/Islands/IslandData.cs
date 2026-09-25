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
public class IslandData
{
    [SerializeField] private IslandType _type;
    [SerializeField] private GameObject _islandPrefab;
    [SerializeField] private string _sceneToLoad;

    public IslandType Type => _type;
    public GameObject IslandPrefab => _islandPrefab;
    public string SceneToLoad => _sceneToLoad;
}
