using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    [Range(0f,100f)] private float _hitpoints;
    
    private int _cannonballs;
    private int _gold;
    private int _grog;
    
    public float Hitpoints
    {
        get { return _hitpoints; }
        set { _hitpoints = value; }
    }

    public int Cannonballs
    {
        get { return _cannonballs; }
        set { _cannonballs = value; }
    }

    public int Gold
    {
        get { return _gold; }
        set { _gold = value; }
    }

    public int Grog
    {
        get { return _grog; }
        set { _grog = value; }
    }
}
