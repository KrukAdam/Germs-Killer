using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;

    public void SetHealthText(int health)
    {
        healthText.text = health.ToString();
    }
}
