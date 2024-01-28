using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add logic to increment the player's pizza count
            GameManager.instance.CollectPizza(1);

            // Destroy the pizza slice object
            Destroy(gameObject);
        }
    }
}
