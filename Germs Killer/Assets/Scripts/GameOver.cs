using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText = null;
    [SerializeField] private GameObject menuButton = null;

    public void EndGame()
    {
        Time.timeScale = 0;
        gameOverText.SetActive(true);
        menuButton.SetActive(true);
    }
}
