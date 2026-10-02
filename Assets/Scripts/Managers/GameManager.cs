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
    
    /*
    private GameplayState _gameState;
    public GameplayState GameState
    {
        get { return _gameState; }
    }

    public UnityEvent<GameplayState, GameplayState> OnGameStateChanged = new UnityEvent<GameplayState, GameplayState>();
    */

    protected override void Awake()
    {
        base.Awake();
        _sceneLoader = GetComponent<SceneLoader>();
    }

    public Player GetPlayer()
    {
        if (player == null)
            player = GetComponent<Player>();
        return player;
    }

    public SceneLoader GetSceneLoader()
    {
        return _sceneLoader;
    }
}
