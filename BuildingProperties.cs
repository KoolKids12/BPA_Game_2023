using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingProperties : MonoBehaviour
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
            DestroyBuilding();
        }
    }

    void DestroyBuilding()
    {
        
        Destroy(gameObject); // This will remove the wall object from the scene
    }
}
