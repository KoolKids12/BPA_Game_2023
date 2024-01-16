using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RholiumGen : MonoBehaviour
{
    [SerializeField] public int refinedholium = 0;  // makes a the final refined holium amount, the full cap, the amount to collect and the timer
    [SerializeField] public int collectrefinedholium = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    [SerializeField] public BuildingProperties RHoliumGen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable() 
    {
        if (gameObject.tag == "RefinedHolium1") // depending on the tag it will generate different ammounts of refined holium for higher levels
        {
            RHoliumGen.maxhealth = 3;
            RHoliumGen.currenthealth = RHoliumGen.maxhealth;
        }
        else if (gameObject.tag == "RefinedHolium2")
        {
            RHoliumGen.maxhealth = 4;
            RHoliumGen.currenthealth = RHoliumGen.maxhealth;
        }
        else if (gameObject.tag == "RefinedHolium3")
        {
            RHoliumGen.maxhealth = 5;
            RHoliumGen.currenthealth = RHoliumGen.maxhealth;
        }
        else{}
    }

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("RefinedHolium1");   
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)   // if the timer is greater than wait time and refined holium cap is not full then it will add the ammount of refined holium that the tag designates to collect refined holium
        {
            if (ResourceManager.refinedHolium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)
            {
                collectrefinedholium += (1 * rhgens1);

            }
        

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("RefinedHolium2");

        
        int rhgens2 = Gens2.Length;

        
            if (ResourceManager.refinedHolium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)   // if the refined holium cap is not full then it will add the ammount of refined holium that the tag designates to collect refined holium
            {
                collectrefinedholium += (2 * rhgens2);

            }
        

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("RefinedHolium3");   

        
        int rhgens3 = Gens3.Length;

        
            if (ResourceManager.refinedHolium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)   // if the refined holium cap is not full then it will add the ammount of refined holium that the tag designates to collect refined holium
            {
                collectrefinedholium += (3 * rhgens3);

            }

            TimeInterval = 0;
        }
    }
     private void OnMouseOver() // if the mouse is over the object and it detects a click it will collect the refined holium into the recource manager
    {
        if (Input.GetMouseButtonDown(0))
        {
            ResourceManager.refinedHolium += collectrefinedholium;
            collectrefinedholium = 0;
        } 

    }

    void Update()
    {
        /*if (collectrefinedholium == 0)
        {
            GetComponent<Animator>().Play("RefinedHoliumGenAnim");
        }
        else if (collectrefinedholium == collectCap)
        {
            GetComponent<Animator>().Play("RefinedHoliumFullAnim");
        }
        else if (collectrefinedholium > 0)
        {
            GetComponent<Animator>().Play("RefinedHoliumGeneratingAnim");
        }*/
    }
}