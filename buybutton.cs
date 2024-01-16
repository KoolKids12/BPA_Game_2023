using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
    public GameObject SquarePrefab, temp, btn;
    public Transform loadpoint;
    private Vector3 loacte;
    private GameObject thing;
    void Start()
    {



    }

    public void SpawnBuilding() // Checks tag of button to find which button was clicked and therefore which object to summon in
    {
        if(ResourceManager.architect >= 1)
        {
            if(btn.tag == "coal")
            {
                if(ResourceManager.oxygen >= 5)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation); // summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "gold")
            {
                if(ResourceManager.coal >= 5)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "oxygen")
            {
                if(ResourceManager.refinedHolium >= 5)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "RH")
            {
                if(ResourceManager.gold >= 5)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "ballista")
            {
                if(ResourceManager.refinedHolium >= 20)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "pumplaun")
            {
                if(ResourceManager.oxygen >= 20)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }
            if(btn.tag == "meater ")
            {
                if(ResourceManager.gold >= 20)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5);// sets timer for building
                    
                }
                

            }if(btn.tag == "wall ")
            {
                if(ResourceManager.gold >= 5)
                {
                    thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);// summons object on loadpoint
            

                    ResourceManager.architect--;

                    Invoke(nameof(Maker), 5); // sets timer for building
                    
                }
                

            }

            
            
        }

    }
    void Maker() // summons temporary building 
    {
        ResourceManager.architect++;

            Destroy(thing); // destroys temp building
            GameObject thing1 = Instantiate(SquarePrefab, loadpoint.position, loadpoint.rotation); // summons the desired building type
    }
}
