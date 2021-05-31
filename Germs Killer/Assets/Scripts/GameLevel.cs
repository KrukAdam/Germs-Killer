using UnityEngine;
using UnityEngine.UI;

public class GameLevel : MonoBehaviour
{
    public int level = 1;
    [SerializeField] private Text levelText = null;

    private void Start()
    {
        levelText.text = level.ToString();
    }
    public void LevelUp()
    {
        level++;
        levelText.text = level.ToString();
    }
}
