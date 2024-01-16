using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGobbler : MonoBehaviour
{
    public int oxycost = 3, goldcost = 5;
    public void ButtonClick()
    {
        if (ResourceManager.oxygen >= oxycost && ResourceManager.gold >= goldcost)
        {
            Debug.Log("gobbler" + ResourceManager.gobbler);
            ResourceManager.gobbler += 1;
            ResourceManager.oxygen -= oxycost;
            ResourceManager.gold -= goldcost;
        }
    }
}
