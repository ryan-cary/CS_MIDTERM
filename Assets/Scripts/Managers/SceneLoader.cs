using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : Singleton<SceneLoader>
{
    public void Load(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void LoadIsland(string scene, Transform respawn)
    {
        GameManager.Instance.GetPlayer().Ship.GetComponent<SpeedStageMovementBehaviour>().resetMovement?.Invoke();
        //okay, yes, this is pretty suboptimal, but it works for now
        
        AlignPlayerShipWithRespawn(respawn);
        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
        StartCoroutine(ActivateScene(scene));
    }

    public void UnloadIsland()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }

    private void AlignPlayerShipWithRespawn(Transform respawn)
    {
        GameManager.Instance.GetPlayer().Ship.gameObject.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        // also disable input here
        GameManager.Instance.GetPlayer().Ship.gameObject.transform.position = respawn.position;
        GameManager.Instance.GetPlayer().Ship.gameObject.transform.rotation = respawn.rotation;
    }
    
    IEnumerator ActivateScene(string scene)
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(scene));
    }
    
    public void Quit()
    { Application.Quit(); }
}
