using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopTraining : MonoBehaviour
{
    public GameObject panel;
    
    private Vector3 scaleChange;

    public void ArmyOpen()
    {
        scaleChange = new Vector3(+1f, +1f, +0f); // scales the panel into existence
            
        panel.transform.localScale = scaleChange;
    }
}
