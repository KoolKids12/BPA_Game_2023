using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopButton : MonoBehaviour
{
    public GameObject panel;
    
    private Vector3 scaleChange;

    public void SpawnBuilding()
    {

        scaleChange = new Vector3(1f, 1f, +0f); // scales up the panel into existence


        panel.transform.localScale = scaleChange;
    }
}
