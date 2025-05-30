using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;

    void Start()
    {
        maxHealth = health;

        // Optional: Hide the GameOverScreen at the start
        GameObject gameOverScreen = GameObject.Find("GameOverScreen");
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(false);
        }
    }

    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        GameObject gameOverScreen = GameObject.Find("GameOverScreenLoader");
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }

        Destroy(gameObject);
    }
}
