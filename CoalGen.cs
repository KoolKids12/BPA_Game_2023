using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalGen : MonoBehaviour
{
    [SerializeField] public int coal = 0; // makes a the final coal amount, the full cap, the amount to collect and the timer
    [SerializeField] public int collectcoal = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    [SerializeField] public BuildingProperties coalGen;

    private void OnEnable() 
    {
        if (gameObject.tag == "Coalgen1")   // depending on the tag it will generate different ammounts of coal for higher levels
        {
            coalGen.maxhealth = 3;
            coalGen.currenthealth = coalGen.maxhealth;
        }
        else if (gameObject.tag == "Coalgen2")
        {
            coalGen.maxhealth = 4;
            coalGen.currenthealth = coalGen.maxhealth;
        }
        else if (gameObject.tag == "Coalgen3")
        {
            coalGen.maxhealth = 5;
            coalGen.currenthealth = coalGen.maxhealth;
        }
        else
        {
        }
    }
    void Start()
    {
        
    }

    void LateUpdate()
    {
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Coal1");   
        
        TimeInterval = TimeInterval + Time.deltaTime;

        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time) // if the timer is greater than wait time and coal cap is not full then it will add the ammount of coal that the tag designates to collect coal 
        {
            if (ResourceManager.coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)
            {
                collectcoal += (1 * rhgens1);

            }
        

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Coal2");

        
        int rhgens2 = Gens2.Length;

        
            if (ResourceManager.coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)  // if the timer is greater than wait time and coal cap is not full then it will add the ammount of coal that the tag designates to collect coal 
            {
                collectcoal += (2 * rhgens2);

            }
        

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Coal3");    // if the timer is greater than wait time and coal cap is not full then it will add the ammount of coal that the tag designates to collect coal

        
        int rhgens3 = Gens3.Length;

        
            if (ResourceManager.coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)
            {
                collectcoal += (3 * rhgens3);

            }
            TimeInterval = 0;
        }
    }
     private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))  // if the mouse is over the object and it detects a click it will collect the coal into the recource manager
        {
            ResourceManager.coal += collectcoal;

           collectcoal = 0;                 
        } 

    }
    void Update()
    {
        
    }
}