using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyShockTrooper : MonoBehaviour
{
    public int oxycost = 15, goldcost = 6;
    public void ButtonClick()
    {
        if (ResourceManager.oxygen >= oxycost && ResourceManager.gold >= goldcost)
        {
            Debug.Log("shocktrooper" + ResourceManager.shocktrooper);
            ResourceManager.shocktrooper +=1;
            ResourceManager.oxygen -= oxycost;
            ResourceManager.gold -= goldcost;
        }
    }
}
