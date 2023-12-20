using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : MonoBehaviour
{
   public int architect;

    private void Start() {
        GameObject[] build1 = GameObject.FindGameObjectsWithTag("Engineer1");
       
        GameObject[] build2 = GameObject.FindGameObjectsWithTag("Engineer2");
       
        GameObject[] build3 = GameObject.FindGameObjectsWithTag("Engineer3");
         
        if(build1.Length > 0)
        {
        architect = 2;
        Debug.Log("Engineer1");
        }
        else if(build2.Length > 0)
        {
        architect = 4;
        Debug.Log("Engineer2");
        }
        else if(build3.Length > 0)
        {
        architect = 6;

        Debug.Log("Engineer3");
         }

        Debug.Log(architect);
    }
}
