using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private Cannon[] _portCannonArray;
    [SerializeField] private Cannon[] _starboardCannonArray;
    [SerializeField] private int cannonCount = 1;
    
    private int _maxCannonCount = 3;

    private bool shootInput = false; 

    public int CannonCount => cannonCount;

    public void AddCannons()
    {
        if (cannonCount < _maxCannonCount)
        {
            cannonCount++;
            _portCannonArray[cannonCount].gameObject.SetActive(true);
            _starboardCannonArray[cannonCount].gameObject.SetActive(true);
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
        Debug.Log("Firing to Starboard");
        /*
        foreach (Cannon cannon in _starboardCannonArray)
            cannon.Fire();
            */
    }
}
