using UnityEngine;

public class Heart : MonoBehaviour
{
    public int health = 0;
    [SerializeField] private HealthUI healthUI = null;
    [SerializeField] private GameOver gameOver = null;

    private void Start()
    {
        healthUI.SetHealthText(health);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        healthUI.SetHealthText(health);
        CheckIsHeAlive();
    }
    private void CheckIsHeAlive()
    {
        if (health <= 0)
        {
            gameOver.EndGame();
        }
    }
}
