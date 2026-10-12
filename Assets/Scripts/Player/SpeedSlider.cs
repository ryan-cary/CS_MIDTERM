using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    private SpeedStageMovementBehaviour _speedController;
    private Slider _slider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _speedController = GameManager.Instance.GetPlayer().Ship.GetComponent<SpeedStageMovementBehaviour>();
        _slider = GetComponent<Slider>();
        
        _speedController.resetMovement.AddListener(Reset);
    }

    public void UpdateSpeedStage()
    {
        _speedController.SetSpeedStage((int)_slider.value);
    }

    private void Reset()
    {
        _slider.value = 0;
    }
}
