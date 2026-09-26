using UnityEngine;

public class StageBasedMovementScheme : PlayerShipMovementScheme
{
    [SerializeField][Range(-1,2)] private int speedStage;
    [SerializeField] private ForceMode _forceMode = ForceMode.Force;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Debug.Log($"speedStage: {speedStage}");
    }

    public void SpeedUp()
    {
        speedStage++;
    }

    public void SlowDown()
    {
        speedStage--;
    }
    
    protected override void ApplyMovement(Vector3 movementVector)
    {
        _rigidbody.AddForce(_rigidbody.transform.rotation * Vector3.forward  + movementVector);
    }
}
