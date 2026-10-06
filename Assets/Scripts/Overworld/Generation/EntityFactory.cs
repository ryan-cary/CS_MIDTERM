using UnityEngine;

public class EntityFactory : MonoBehaviour
{
    [SerializeField] private GameObject[] entityPrefabs;

    public GameObject RandomEntity()
    {
        int random = Random.Range(0, entityPrefabs.Length);

        return entityPrefabs[random];
    }
}
