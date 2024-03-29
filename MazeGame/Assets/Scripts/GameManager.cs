using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int pizzasCollected = 0;
    private int pizzasToCollect;

    public Text pizzaCountText; // Reference the UI in the inspector

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

        InitializeLevel(); // Initialize level settings
    }

    public void CollectPizza(int amount)
    {
        pizzasCollected += amount;
        pizzaCountText.text = "Pizzas: " + pizzasCollected; // Updates the UI text

        CheckLevelCompletion();
    }

    void InitializeLevel()
    {
        pizzasCollected = 0;
        pizzasToCollect = Random.Range(10, 16);
    }

    void CheckLevelCompletion() // Call LevelCompleted when enough pizzas are collected
    {
        if (pizzasCollected >= pizzasToCollect)
        { 
            LoadNextLevel(); // Load next level or Scene
        }
    }

    void LoadNextLevel()
    {
        // Organize the scenes based on how you want to progress the maps
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        // Reinitialize level variables for the new level
        InitializeLevel();
    }
}
