using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SceneName") // Enters the first level
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the application/game
    }
}
