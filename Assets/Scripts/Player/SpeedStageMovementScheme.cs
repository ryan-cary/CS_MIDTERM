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

    private Vector3 CalculateCourseVector()
    {
        Quaternion heading = gameObject.transform.rotation;
        Vector3 courseVector = heading * Vector3.forward;

        return courseVector.normalized;
    }
    
    protected override void ApplyMovement(Vector3 movementVector)
    {
        Vector3 verticalMovement = Vector3.Project(movementVector, gameObject.transform.forward);
        
        if (Vector3.Dot(verticalMovement, gameObject.transform.forward) > 0.25f)
            speedStage += 1;
        else if (Vector3.Dot(verticalMovement, gameObject.transform.forward) < -0.25f)
            speedStage -= 1;
        
        Vector3 course = CalculateCourseVector();
        
        _rigidbody.linearVelocity = course * (shipSpeed * speedStage * Time.deltaTime);
        
    }
}
