using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
    }
}

