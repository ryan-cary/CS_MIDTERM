using UnityEngine;
using UnityEngine.Events;

public enum GameplayState
{
    MainMenu,
    Overworld,
    Island,
    GameOver
}

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Player player;

    private SceneLoader _sceneLoader;
    
    private GameplayState _gameState;
    public GameplayState GameState
    {
        get { return _gameState; }
    }

    public UnityEvent<GameplayState, GameplayState> OnGameStateChanged = new UnityEvent<GameplayState, GameplayState>();

    void Awake()
    {
        player = new Player();
        player.Ship = new PlayerShip();
        
        _gameState = GameplayState.MainMenu;
        _sceneLoader = GetComponent<SceneLoader>();
        Debug.Log(_sceneLoader);
    }

    public static GameManager GetInstance()
    { return Instance; }

    public Player GetPlayer()
    {
        return player;
    }

    public SceneLoader GetSceneLoader()
    {
        return _sceneLoader;
    }
}
