using UnityEngine;

public abstract class OverworldEntity : MonoBehaviour, IEncounterable
{



    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //acquire target (player)
    }

    // Update is called once per frame
    void Update()
    {
        //move towards player
        //if in range: take action
    }

    public virtual void DoEntityAction()
    {
        Debug.Log($"Entity {name} has taken an action");
    }
}
