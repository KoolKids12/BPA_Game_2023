using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopButton : MonoBehaviour
{
    public GameObject panel;
    
    private Vector3 scaleChange;

    public void SpawnBuilding()
    {

        scaleChange = new Vector3(+1f, +1f, +0f);


        panel.transform.localScale += scaleChange;
    }
}
