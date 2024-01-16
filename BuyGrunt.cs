using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGrunt : MonoBehaviour
{
    public int oxycost = 3, goldcost = 3;
    public void ButtonClick()
    {
        if (ResourceManager.oxygen >= oxycost && ResourceManager.gold >= goldcost) // checks if they have the needed resources to buy
        {
            Debug.Log("grunt" + ResourceManager.grunt); 
            ResourceManager.grunt+=1; // adds a grunt
            ResourceManager.oxygen -= oxycost;// takes away
            ResourceManager.gold -= goldcost; // prices
        }
    }
}
