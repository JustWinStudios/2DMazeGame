using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame"); // Replace with whatever the starting level name is
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
