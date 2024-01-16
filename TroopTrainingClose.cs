using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopTrainingClose : MonoBehaviour
{
  
    public GameObject panel;
    
    private Vector3 scaleChange;

    public void CloseTraining()
    {

        scaleChange = new Vector3(-1f, -1f, +0f); // scales panel out of existence


        panel.transform.localScale += scaleChange;
    }
}