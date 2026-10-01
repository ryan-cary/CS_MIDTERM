using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInventory _inventory;
    private float _hitpoints;
    
    [SerializeField] private PlayerShip _ship;

    public Player()
    {
        this._inventory = new PlayerInventory();
        this._hitpoints = 100;
        this._ship = Object.FindFirstObjectByType<PlayerShip>();
    }
    
    //TODO when creating a player, if no PlayerShip in scene, how to assign PlayerShip?

    public Player(PlayerData pData)
    {
        this._inventory = new PlayerInventory(pData);
        this._hitpoints = pData.Hitpoints;
        this._ship = Object.FindFirstObjectByType<PlayerShip>();
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

    public void TakeDamage(float damage)
    {
        _hitpoints -= damage;
        if (_hitpoints <= 0)
        {
            SceneLoader.Instance.Load("GameOver");
        }
    }

    public void RepairDamage(float repair)
    {
        _hitpoints += repair;
        if (_hitpoints > 100)
            _hitpoints = 100;
    }
}
