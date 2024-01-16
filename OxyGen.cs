using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyGen : MonoBehaviour
{
    [SerializeField] public int oxygen = 0;  // makes a the final oxygen amount, the full cap, the amount to collect and the timer
    [SerializeField] public int collectoxygen = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    [SerializeField] public BuildingProperties oxyGen;
    // Start is called before the first frame update
    private void OnEnable() 
    {
        if (gameObject.tag == "Oxygen1")    // depending on the tag it will generate different ammounts of oxygen for higher levels
        {
            oxyGen.maxhealth = 3;
            oxyGen.currenthealth = oxyGen.maxhealth;
        }
        else if (gameObject.tag == "Oxygen2")
        {
            oxyGen.maxhealth = 4;
            oxyGen.currenthealth = oxyGen.maxhealth;
        }
        else if (gameObject.tag == "Oxygen3")
        {
            oxyGen.maxhealth = 5;
            oxyGen.currenthealth = oxyGen.maxhealth;
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
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Oxygen1");  
        
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)   // if the timer is greater than wait time and oxygen cap is not full then it will add the ammount of oxygen that the tag designates to collect oxygen 
        {
            if (ResourceManager.oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)
            {
                collectoxygen += (1 * rhgens1);

            }
            
        

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Oxygen2");

        
        int rhgens2 = Gens2.Length;

        
            if (ResourceManager.oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)    // if the oxygen cap is not full then it will add the ammount of oxygen that the tag designates to collect oxygen 
            {
                collectoxygen += (2 * rhgens2);

            }
        

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Oxygen3");

        
        int rhgens3 = Gens3.Length;

        
            if (ResourceManager.oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)    // if the oxygen cap is not full then it will add the ammount of oxygen that the tag designates to collect oxygen
            {
                collectoxygen += (3 * rhgens3);

            }

            TimeInterval = 0;
        }
    
    }
     private void OnMouseOver()  // if the mouse is over the object and it detects a click it will collect the oxygen into the recource manager
    {
        if (Input.GetMouseButtonDown(0))
        {
            ResourceManager.oxygen += collectoxygen;
            collectoxygen = 0;                 
        } 
    }
}