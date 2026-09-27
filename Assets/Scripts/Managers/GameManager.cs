using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private Player player;

    void Start()
    {
        player = new Player();
        player.Data = new PlayerData();
        player.Ship = new PlayerShip();
    }
}
