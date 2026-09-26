using UnityEngine;

public class PlayerData
{
    [Range(0f,100f)] private float _hitpoints;
    
    private int _cannonballs;
    private int _gold;
    private int _grog;

    public float Hitpoints => _hitpoints;
    public int Cannonballs => _cannonballs;
    public int Gold => _gold;
    public int Grog => _grog;

    public void RepairHP(float value)
    {
        _hitpoints += value;
        if (_hitpoints > 100)
            _hitpoints = 100;
    }

    public void DamageHP(float value)
    {
        _hitpoints -= value;
        if (_hitpoints <= 0)
        {
            Debug.Log("Oh dear, you are dead!");
            // do death things
        }
        
    }

    public void AddCannonballs(int value)
    {
        _cannonballs += value;
    }

    public void RemoveCannonballs(int value)
    {
        if (_cannonballs <= 0)
        {
            Debug.Log("You are out of cannonballs!");
            _cannonballs = 0;
        }
        _cannonballs -= value;
    }

    public void AddGold(int value)
    {
        _gold += value;
    }

    public bool RemoveGold(int value)
    {
        if (_gold < value)
        {
            Debug.Log("You don't have enough money!");
            return false;
        }
        else
        {
            _gold -= value;
            return true;
        }
    }

    public void AddGrog(int value)
    {
        _grog += value;
    }

    public void RemoveGrog(int value)
    {
        _grog -= value;
        if (_grog <= 0)
            Debug.Log("You are out of grog! Your crew has mutinied!");
    }
}
