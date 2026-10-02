using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInventory _inventory;
    
    [SerializeField] private PlayerShip _ship;

    private void Start()
    {
        _ship = FindFirstObjectByType<PlayerShip>();
    }

    public PlayerInventory Inventory
    {
        get => _inventory;
        set => _inventory = value;
    }

    public PlayerShip Ship
    {
        get => _ship;
        set => _ship = value;
    }
}
