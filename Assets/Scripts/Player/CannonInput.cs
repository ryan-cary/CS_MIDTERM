using UnityEngine;

public class CannonInput : MonoBehaviour
{
    private PlayerShip _ship;

    private bool _portCannonInput;
    private bool _starboardCannonInput;

    private void Start()
    {
        _ship = GetComponent<PlayerShip>();
    }

    private void Update()
    {
        GetPortCannonInput();
        GetStarboardCannonInput();
    }

    private void GetPortCannonInput()
    {
        _portCannonInput = Input.GetMouseButton(0);
        _ship.SetPortFireInput(_portCannonInput);
    }
    
    private void GetStarboardCannonInput()
    {
        _starboardCannonInput = Input.GetMouseButton(1);
        _ship.SetStarboardFireInput(_starboardCannonInput);
    }
}
