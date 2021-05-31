using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string nameSceneToLoad = "Menu";

    public void LoadAScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(nameSceneToLoad);
    }
}
