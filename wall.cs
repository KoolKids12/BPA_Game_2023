using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
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
        if (other.CompareTag("Bomber"))
        {
            // Decrease health when a square hits the triangle
            WallDie();

            // Optionally, you can destroy the square on collision
           // Destroy(other.gameObject);
        }
    }

   public void WallTakeDamage(int damage)
    {
        currentHealth -= damage;
Debug.Log("House Health: " + currentHealth);
        // Check if the triangle's health has reached zeros
        if (currentHealth <= 0)
        {
            WallDie();
        }
    }

    void WallDie()
    {
        // Handle what happens when the triangle's health reaches zero
        Debug.Log("Wall destroyed!");
        Destroy(gameObject);
    }
    
}
