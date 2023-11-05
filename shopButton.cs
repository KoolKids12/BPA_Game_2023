using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopButton : MonoBehaviour
{
    public GameObject panel;
    
    private Vector3 scaleChange;

    public void SpawnBuilding()
    {
        if(scaleChange.x <= 1 && scaleChange.y <= 1)
        {
             scaleChange = new Vector3(+1f, +1f, +0f);
        }
       


        panel.transform.localScale = scaleChange;
    }
}
