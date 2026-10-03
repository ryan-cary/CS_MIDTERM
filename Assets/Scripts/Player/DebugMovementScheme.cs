using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DebugMovementScheme : PlayerShipMovementScheme
{

    [SerializeField] private ForceMode forceMode = ForceMode.VelocityChange;

    private Rigidbody _rigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // redundant code for now
    protected override void Update()
    {
        base.Update();
        //BroadcastSpeed?.Invoke(rigidbody.linearVelocity.magnitude);
    }

    protected override void ApplyMovement(Vector3 movementVector)
    {
        if (movementVector == Vector3.zero)
        {
            _rigidbody.linearVelocity = movementVector;
        }
        else
        {
            _rigidbody.AddForce(movementVector * Time.deltaTime, forceMode);    
        }
    }
}
