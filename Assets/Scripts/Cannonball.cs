using System;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    [SerializeField] private int _damage;
    
    private void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();
        if (damageable != null)
            damageable.TakeDamage(_damage);
    }
}
