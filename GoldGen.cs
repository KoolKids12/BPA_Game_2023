using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGen : MonoBehaviour
{
    [SerializeField] public int gold = 0;

    [SerializeField] public int collectgold = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    [SerializeField] public BuildingProperties goldGen;

    private void OnEnable() // Gives them health depending on what level the gen is
    {
        if (gameObject.tag == "Goldgen1")
        {
            goldGen.maxhealth = 3;
            goldGen.currenthealth = goldGen.maxhealth;
        }
        else if (gameObject.tag == "Goldgen2")
        {
            goldGen.maxhealth = 4;
            goldGen.currenthealth = goldGen.maxhealth;
        }
        else if (gameObject.tag == "Goldgen3")
        {
            goldGen.maxhealth = 5;
            goldGen.currenthealth = goldGen.maxhealth;
        }
        else
        {
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Gold1"); // finds level one gold gens
        
        TimeInterval = TimeInterval + Time.deltaTime; // adds to time interval
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time) // checks if the cooldown has been long enough
        {
            if (ResourceManager.gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap) // is it in constraints of gold cap
            {
                collectgold += (1 * rhgens1); // adds to gold
            }
        

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Gold2");

        
        int rhgens2 = Gens2.Length;

        
            if (ResourceManager.gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap)// is it in constraints of gold cap
            {
                collectgold += (2 * rhgens2); // adds to gold
            }
        

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Gold3");

        
        int rhgens3 = Gens3.Length;

        
            if (ResourceManager.gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap)// is it in constraints of gold cap
            {
                collectgold += (3 * rhgens3); // adds to gold
            }
            TimeInterval = 0;
        }
    }

    void Update()
    {
       
    }
     private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0)) // get mouse button to activate collection
        {
            ResourceManager.gold += collectgold;
            collectgold = 0;                 
        } 

    }
}