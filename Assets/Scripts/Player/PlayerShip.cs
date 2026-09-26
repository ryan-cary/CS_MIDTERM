using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private int cannonCount;
    [SerializeField] private int maxCannonCount;

    public int CannonCount => cannonCount;

    public void AddCannons()
    {
        if (cannonCount < maxCannonCount)
            cannonCount++;
        else
            Debug.Log("You have the maximum number of cannons already!");
    }
}
