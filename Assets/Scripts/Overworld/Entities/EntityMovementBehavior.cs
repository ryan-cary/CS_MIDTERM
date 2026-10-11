using UnityEngine;

public abstract class EntityMovementBehavior : MonoBehaviour
{
    public Transform target;
    public abstract void Move();
}
