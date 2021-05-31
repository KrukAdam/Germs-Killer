using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    [SerializeField] private GameLevel gameLevel = null;
    [SerializeField] private Text timeText = null;
    private float gameTime = 0;
    private float timeToNextLevel = 10;

    void Update()
    {
        gameTime += Time.deltaTime;
        timeText.text = gameTime.ToString("F2");

        if (gameTime > timeToNextLevel)
        {
            gameLevel.LevelUp();
            timeToNextLevel += 10f;
        }
    }
}
