using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameSceneName"); // Replace "GameSceneName" with the name of your game scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
