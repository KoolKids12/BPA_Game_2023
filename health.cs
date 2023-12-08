using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public int maxHealth = 5; // Adjust the maximum health as needed
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
       
    }

    // Update is called once per frame
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Square"))
        {
            // Decrease health when a square hits the triangle
            TakeDamage(1);

            // Optionally, you can destroy the square on collision
           // Destroy(other.gameObject);
        }
    }

   public void TakeDamage(int damage)
    {
        currentHealth -= damage;
Debug.Log("House Health: " + currentHealth);
        // Check if the triangle's health has reached zero
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Handle what happens when the triangle's health reaches zero
        Debug.Log("Triangle destroyed!");
        Destroy(gameObject);
    }
    
}
