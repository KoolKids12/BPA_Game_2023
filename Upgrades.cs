using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [SerializeField] public GameObject Coal2, Coal3, Gold2, Gold3, Oxy2, Oxy3, Rholium2, Rholium3, Builder2, Builder3;
    public GameObject building;

    public void BuyPannel()
    {
        Vector3 loadpoint = new Vector3();

        if (building != null)
        {
        if(building.tag == "Coal1")
        {
            building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Coal2, loadpoint, Quaternion.identity);    
        }       
        else if(building.tag == "Coal2")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Coal3, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "Gold1")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Gold2, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "Gold2")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Gold3, loadpoint, Quaternion.identity);    
        }       
        else if(building.tag == "Oxygen1")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Oxy2, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "Oxygen2")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Oxy3, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "RefinedHolium1")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Rholium2, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "RefinedHolium2")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Rholium3, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "Engineer1")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Builder2, loadpoint, Quaternion.identity);    
        }        
        else if(building.tag == "Engineer2")
        {
                        building.transform.position = loadpoint;

            Destroy(building);
            
            Instantiate(Builder3, loadpoint, Quaternion.identity);    
        }        
        }
    }

    public void clickedon(GameObject buid)
    {
        Debug.Log("buid");
        building = buid;
    }
}
