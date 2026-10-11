using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private float projectileVelocity = 25.0f;
    [SerializeField] private float lifetime = 5.0f;
    [SerializeField] private Transform barrel;

    [SerializeField] private ObjectPool cannonballs;
    
    public void Fire()
    {
        PooledObject projectile = cannonballs.GetPooledObject();

        if (projectile == null)
        {
            Debug.Log("No projectile available...");
            return;
        }
            
        projectile.gameObject.SetActive(true);

        Rigidbody pBody = projectile.GetComponent<Rigidbody>();

        pBody.position = barrel.position;
        pBody.rotation = barrel.rotation;
        
        pBody.AddForce(Vector3.forward * projectileVelocity, ForceMode.Impulse);

        Debug.Log("Firing!");
        
        cannonballs.RecyclePooledObject(projectile, lifetime);
    }
}
