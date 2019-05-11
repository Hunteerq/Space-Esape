using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneHandler : MonoBehaviour {

    public void OnClick(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
