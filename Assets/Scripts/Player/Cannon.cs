using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileVelocity = 25.0f;
    [SerializeField] private float damageMultiplier = 1.0f;
    [SerializeField] private Transform barrel;

    public void Fire()
    {
        Debug.Log($"Firing cannonball!");
    }
}
