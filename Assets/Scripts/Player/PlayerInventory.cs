using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory
{
    private int _cannonballs;
    private int _gold;
    private int _grog;

    public UnityEvent OnGoldUpdate;
    public UnityEvent OnGrogUpdate;
    public UnityEvent OnCannonballsUpdate;

    public int Cannonballs => _cannonballs;
    public int Gold => _gold;
    public int Grog => _grog;


    public PlayerInventory()
    {
        this._cannonballs = 24;
        this._gold = 0;
        this._grog = 100;
    }
    
    public PlayerInventory(PlayerData pData)
    {
        this._cannonballs = pData.Cannonballs;
        this._gold = pData.Gold;
        this._grog = pData.Grog;
    }

    private void Start()
    {
        OnGrogUpdate.AddListener(CheckForMutiny);
    }
    
    public void AddCannonballs(int value)
    {
        _cannonballs += value;
        OnCannonballsUpdate?.Invoke();
    }

    public void RemoveCannonballs(int value)
    {
        if (_cannonballs <= 0)
        {
            Debug.Log("You are out of cannonballs!");
            _cannonballs = 0;
        }
        _cannonballs -= value;
        OnCannonballsUpdate?.Invoke();
    }

    public void AddGold(int value)
    {
        _gold += value;
        OnGoldUpdate?.Invoke();
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
            OnGoldUpdate?.Invoke();
            return true;
        }       
        
    }

    public void AddGrog(int value)
    {
        _grog += value;
        OnGrogUpdate?.Invoke();
    }

    public void RemoveGrog(int value)
    {
        _grog -= value;
        OnGrogUpdate?.Invoke();        
    }

    private void CheckForMutiny()
    {
        if (_grog <= 0)
            Debug.Log("You are out of grog! Your crew has mutinied!");
    }
}
