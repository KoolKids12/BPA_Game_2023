using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeButton : MonoBehaviour
{
    public GameObject panel, building;
    public bool isOpen = false;
    private ClickTimer clickTimer;
    private Vector3 scaleChange;
    public TextMeshProUGUI coalcost, goldcost, oxycost, rhcost;
    [SerializeField] private int coal, gold, oxy, rh;
    
    public void SpawnBuilding()
    {
        if(isOpen)// if the panel is open it closes, vice versa
        {
            scaleChange = new Vector3(-1f, -1f, +0f); 

            panel.transform.localScale += scaleChange;
            isOpen = false;
        }
        else if (!isOpen)
        {
            scaleChange = new Vector3(1f, 1f, +0f);

            panel.transform.localScale  = scaleChange;
            isOpen = true;
        }
        
    }
    public void setUpgrade(GameObject build) // get the building
    {
        building = build;
    }

    void Update()
    {
        if (building != null)// if building exists
        {
            if(building.tag == "Coal1") // it checks the tag of the building and then changes the price to the appropriate price to upgrade said building
            {
                oxy = 10;
                coal = 0;
                gold = 0;
                rh = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
    
            }       
            else if(building.tag == "Coal2")
            {
                oxy = 20;
                coal = 8;
                gold = 0;
                rh = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }     
            else if(building.tag == "Gold1")
            {
                coal = 10;
                gold = 0;
                rh = 0;
                oxy = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
    
            }       
            else if(building.tag == "Gold2")
            {
               coal = 20;
                gold = 8;
                rh = 0;
                oxy = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }  
            else if(building.tag == "Oxygen1")
            {
                rh = 10;
                gold = 0;
                oxy = 0;
                coal = 0;

                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }   
    
             
            else if(building.tag == "Oxygen2")
            {
                rh = 20;
                oxy = 8;
                coal = 0;
                gold = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }     
            else if(building.tag == "RefinedHolium1")
            {
                gold = 10;
                oxy = 0;
                coal = 0;
                rh = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }       
            else if(building.tag == "RefinedHolium2")
            {
                gold = 10;
                rh = 8;
                oxy = 0;
                coal = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }   
            else if(building.tag == "Bridge1")
            {
                gold = 30;
                rh = 30;
                coal = 30;
                oxy = 30;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
    
            }         
            else if(building.tag == "Bridge2")
            {
                gold = 60;
                rh = 60;
                coal = 60;
                oxy = 60;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }
            else if(building.tag == "Engineer1")
            {
                rh = 15;
                gold = 5;
                oxy = 5;
                coal = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            } 
            else if(building.tag == "Engineer2")
            {
                rh = 20;
                gold = 8;
                oxy = 5;
                coal = 0;
                coalcost.text = coal.ToString();
                goldcost.text = gold.ToString();
                oxycost.text = oxy.ToString();
                rhcost.text = rh.ToString();
            
    
            }
        }
        else
        {
        
        }
    }   
}
