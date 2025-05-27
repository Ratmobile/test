using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineUnlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached finish line!");

            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

            if (currentLevel + 1 > unlockedLevel)
            {
                PlayerPrefs.SetInt("UnlockedLevel", currentLevel + 1);
                PlayerPrefs.Save();
            }

            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            Debug.Log("Triggered by something else: " + other.name);
        }
    }
}
