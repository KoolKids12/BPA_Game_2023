using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMech : MonoBehaviour
{
    public int coalcost = 5, goldcost = 3, rhcost = 10;
    public void ButtonClick()
    {
        if (ResourceManager.coal >= coalcost && ResourceManager.gold >= goldcost && ResourceManager.refinedHolium >= rhcost)
        {
            Debug.Log("mech" + ResourceManager.mech);
            ResourceManager.mech +=1;
            ResourceManager.coal -= coalcost;
            ResourceManager.gold -= goldcost;
            ResourceManager.refinedHolium -= rhcost;
        }
    }
}
