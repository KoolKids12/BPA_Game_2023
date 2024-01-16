using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingProperties : MonoBehaviour
{
    [SerializeField] public float maxhealth = 3;

    [SerializeField] public float currenthealth;

    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(float damage) // function for the buildings to take damage
    {
        currenthealth -= damage;
        
        if (currenthealth <= 0) // if health is 0 or less destroy gameobject
        {
            DestroyBuilding();
        }
    }

    void DestroyBuilding()
    {
        
        Destroy(gameObject); // This will remove the wall object from the scene
    }
}
