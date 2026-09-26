using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private Cannon[] _portCannonArray;
    [SerializeField] private Cannon[] _starboardCannonArray;
    [SerializeField] private int cannonsPerSide= 1;
    
    private int _maxCannonCount = 3;

    private bool shootInput = false; 

    public int CannonCount => cannonsPerSide;

    public void AddCannons()
    {
        if (cannonsPerSide < _maxCannonCount)
        {
            cannonsPerSide++;
            _portCannonArray[cannonsPerSide].gameObject.SetActive(true);
            _starboardCannonArray[cannonsPerSide].gameObject.SetActive(true);
        }
        else
            Debug.Log("You have the maximum number of cannons already!");
    }

    public void FirePortCannons()
    {
        
        /*
        foreach (Cannon cannon in _portCannonArray)
            cannon.Fire();
            */
    }
    
    public void FireStarboardCannons()
    {
        /*
        foreach (Cannon cannon in _starboardCannonArray)
            cannon.Fire();
            */
    }
}
