using UnityEngine;

public class OverworldEntity : MonoBehaviour, IEncounterable
{

    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntityAction()
    {
        Debug.Log($"Entity {name} has taken an action");
    }
}
