using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    private Transform _respawn;
    [SerializeField] private Scene overworld;

    private void Start()
    {
        overworld = SceneManager.GetSceneByName("Overworld");
    }

    public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadIsland(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }

    public void UnloadIsland()
    {
        Scene sceneToUnload = SceneManager.GetActiveScene();
        //GameManager.Instance.GetPlayer().Ship.transform.position = _respawn.position;
        SceneManager.SetActiveScene(overworld);
        SceneManager.UnloadSceneAsync(sceneToUnload);

    }
    
    public void Quit()
    { Application.Quit(); }
}
