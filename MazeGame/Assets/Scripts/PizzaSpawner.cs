using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSpawner : MonoBehaviour
{
    public GameObject pizzPrefab;
    public LayerMask wallLayer; // Assign the Wall layer in the inspector
    public float spawnInterval = 5f; // Time between spawns
    public Vector2 mapSize = new Vector2(20, 20); // Predefines the map's size, adjust based on map size

    private float timer;

    void Awake()
    {
        if (instance == null)
        {
            instance == null;

            DontDestroyOnLoad(gameObject);
        }

        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        timer += timer.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPizza();
            timer = 0;
        }
    }

    void SpawnPizza()
    {
        Vector2 spawnPoint = Vector2.zero;
        bool validPosition = false;

        // Attempt to find a valid position

        for (int i = 0; i < 100; i++) // Limits finding attempts to prevent infinite loop
        {
            float x = Random.Range(-mapSize.x / 2, mapSize.x / 2);
            float y = Random.Range(-mapSize.y / 2, mapSize.y / 2);

            spawnPoint = new Vector2(x, y);

            // Check if the spawn point is in a wall
            if (!Physics2D.OverlapCircle(spawnPoint, 0.5f, wallLayer))
            {
                validPosition = true;
                break;
            }
        }

        if (validPosition)
        {
            Instantiate(pizzaPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
