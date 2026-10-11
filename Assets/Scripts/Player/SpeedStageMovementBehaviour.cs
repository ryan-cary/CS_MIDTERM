using UnityEngine;
using UnityEngine.UI;

public class SpeedStageMovementBehaviour : PlayerShipMovementBehaviour
{
    [SerializeField][Range(-1,2)] private int speedStage;
    
    [SerializeField] private Slider _speedStageSlider;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _speedStageSlider = FindFirstObjectByType<Slider>();
    }
    
    protected void Update()
    {
        base.Update();
    }

    public void SetSpeedStage()
    {
        int _temp = speedStage;
        speedStage = (int)_speedStageSlider.value;
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

    public void ResetMovement()
    {
        speedStage = 0;
        _speedStageSlider.value = 0f;
        
    }
}
