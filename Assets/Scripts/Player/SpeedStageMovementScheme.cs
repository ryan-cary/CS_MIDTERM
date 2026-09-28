using UnityEngine;

public class SpeedStageMovementScheme : PlayerShipMovementScheme
{
    [SerializeField] private float shipSpeed = 20;
    [SerializeField][Range(-1,2)] private int speedStage;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void SpeedUp()
    {
        speedStage++;
        Debug.Log("Speeding up!");
    }

    public void SlowDown()
    {
        speedStage--;
        Debug.Log("Slowing down!");
    }

    private Vector3 CalculateMovementVector()
    {
        Quaternion heading = gameObject.transform.rotation;
        Vector3 movementVector = heading * Vector3.forward;

        return movementVector;
    }
    
    protected override void ApplyMovement(Vector3 movementVector)
    {
        _rigidbody.linearVelocity = CalculateMovementVector() * (shipSpeed * speedStage * Time.deltaTime);
        
    }
}
