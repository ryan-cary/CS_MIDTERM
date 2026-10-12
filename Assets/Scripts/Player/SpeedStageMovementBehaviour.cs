using UnityEngine;
using UnityEngine.Events;

public class SpeedStageMovementBehaviour : PlayerShipMovementBehaviour
{
    [SerializeField][Range(-1,2)] private int speedStage;
    private Rigidbody _rigidbody;

    public UnityEvent resetMovement;

    public int Stage => speedStage;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        resetMovement.AddListener(Reset);
    }
    
    protected void Update()
    {
        base.Update();
    }

    public void SetSpeedStage(int stage)
    {
        speedStage = stage;
    }

    private Vector3 CalculateCourseVector()
    {
        Quaternion heading = gameObject.transform.rotation;
        Vector3 courseVector = heading * Vector3.forward;

        return courseVector.normalized;
    }
    
    protected override void ApplyMovement(Vector3 movementVector)
    {
        
        Vector3 course = CalculateCourseVector();
        
        _rigidbody.linearVelocity = course * (movementSpeed * speedStage * Time.deltaTime);
        
    }

    private void Reset()
    {
        speedStage = 0;
    }

}
