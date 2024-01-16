using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Upgrades : MonoBehaviour
{
    [SerializeField] public GameObject Coal2, Coal3, Gold2, Gold3, Oxy2, Oxy3, Rholium2, Rholium3, Builder2, Builder3, Bridge2, Bridge3; // sets all upgradable game objects
    public GameObject building;
    public TextMeshProUGUI coalcost, goldcost, oxycost, rhcost; // costs of resources
    [SerializeField] private int coal, gold, oxy, rh;
    [SerializeField] public Camera cam;
    public void BuyPannel()
    {
        Vector3 loadpoint = new Vector3();

        if (building != null)// if building exists
        {
        if(building.tag == "Coal1") // gets the tag from building and changes the price to the correct price for said tag. It then subtracts the price and summons the upgraded building.
        {
            oxy = 10;
            coal = 0;
            gold = 0;
            rh = 0;
            coalcost.text = coal.ToString();
            goldcost.text = gold.ToString();
            oxycost.text = oxy.ToString();
            rhcost.text = rh.ToString();
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Coal2, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Coal3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Gold2, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Gold3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
                loadpoint = building.transform.position;

                Destroy(building);
            
                var built = Instantiate(Oxy2, loadpoint, Quaternion.identity);
                var dragcomponent = built.GetComponent<DragObjects>();
                dragcomponent.cam = cam;

                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Oxy3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;
    
                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Rholium2, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Rholium3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Bridge2, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;
            

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Bridge3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Builder2, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
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
            if(ResourceManager.coal >= coal && ResourceManager.gold >= gold && ResourceManager.oxygen >= oxy && ResourceManager.refinedHolium >= rh)
            {
             loadpoint = building.transform.position;

            Destroy(building);
            
            var built = Instantiate(Builder3, loadpoint, Quaternion.identity);
            var dragcomponent = built.GetComponent<DragObjects>();
            dragcomponent.cam = cam;

                ResourceManager.coal -= coal;
                ResourceManager.oxygen -= oxy;
                ResourceManager.refinedHolium -= rh;
                ResourceManager.gold -= gold;
            }
    
        }
        }
    }

    public void clickedon(GameObject buid) // sets building (most recent one to be clicked)
    {
        building = buid;
    }
}
