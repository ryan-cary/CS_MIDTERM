using UnityEngine;

public class SceneManager : Singleton<SceneManager>
{
    public void Load(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
    
    public void Quit()
    { Application.Quit(); }
}
