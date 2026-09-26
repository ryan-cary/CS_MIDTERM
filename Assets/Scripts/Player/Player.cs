using UnityEngine;

public class Player
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private PlayerShip _ship;

    public PlayerData Data => _data;
    public PlayerShip Ship => _ship;
}
