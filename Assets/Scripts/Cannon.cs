using System;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private ObjectPool cannonballs;
    
    [Header("Projectiles")]
    [SerializeField] private float projectileVelocity = 50.0f;
    [SerializeField] private float lifetime = 5.0f;
    [SerializeField] private Vector3 firingAngle = new Vector3(0, 0.15f, 0);

    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void Fire()
    {
        if (GameManager.Instance.GetPlayer().Inventory.Cannonballs <= 0)
            return;
        
        PooledObject projectile = cannonballs.GetPooledObject();

        if (projectile == null)
        {
            return;
        }
        
        GameManager.Instance.GetPlayer().Inventory.RemoveCannonballs(1);
        
        _audio.Play();
        
        projectile.gameObject.SetActive(true);

        Rigidbody pBody = projectile.GetComponent<Rigidbody>();

        pBody.position = barrel.position;
        pBody.rotation = barrel.rotation;
        
        pBody.AddForce(transform.rotation * (Vector3.forward + firingAngle) * projectileVelocity, ForceMode.Impulse);
        
        cannonballs.RecyclePooledObject(projectile, lifetime);
    }
}
