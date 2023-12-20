using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] public int maxhealth = 3;

    [SerializeField] public int currenthealth;

    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        
        if (currenthealth <= 0)
        {
            DestroyWall();
        }
    }

    void DestroyWall()
    {
        
        Destroy(gameObject); // This will remove the wall object from the scene
    }
}