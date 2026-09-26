using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Cannonball cannonballPrefab;
    [SerializeField] private int damageMultiplier;

    public void Fire()
    {
        Debug.Log($"Firing cannonball!");
    }
}
