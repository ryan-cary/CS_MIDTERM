using UnityEngine;

public class Player
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private PlayerShip _ship;

    public PlayerData Data
    {
        get => _data;
        set => _data = value;
    }

    public PlayerShip Ship
    {
        get => _ship;
        set => _ship = value;
    }
}
