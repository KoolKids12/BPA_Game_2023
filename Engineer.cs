using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : MonoBehaviour
{
   public int architect;

    private void Start() {
        GameObject[] build1 = GameObject.FindGameObjectsWithTag("Engineer1"); // finds objects
       
        GameObject[] build2 = GameObject.FindGameObjectsWithTag("Engineer2"); // finds objects
       
        GameObject[] build3 = GameObject.FindGameObjectsWithTag("Engineer3"); // finds objects
         
        if(build1.Length > 0) // sets he corect amount of architects
        {
        architect = 2;
        }
        else if(build2.Length > 0)
        {
        architect = 4;
        }
        else if(build3.Length > 0)
        {
        architect = 6;

         }

        ResourceManager.architect = architect; // sets resourcemanager to the amount of architects
    }
}
