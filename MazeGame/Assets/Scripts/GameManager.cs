using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int pizzasCollected = 0;
    private int pizzasToCollect;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectPizza(int amount)
    {
        pizzasCollected += amount;
        CheckLevelCompletion();
    }

    void InitializeLevel()
    {

    }

    void CheckLevelCompletion()
    {
        if (pizzasCollected >= pizzasToCollect)
        {
            //Load next level or Scene
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        pizzasCollected = 0;
        pizzasToCollect = Random.Range(10, 16);

        // Organize the scenes based on how you want to progress the maps
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
