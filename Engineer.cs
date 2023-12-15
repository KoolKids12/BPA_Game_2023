using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : MonoBehaviour
{
   public int architect;

    private void Start() {
        GameObject[] build1 = GameObject.FindGameObjectsWithTag("Engineer1");
        int engineer = build1.Length;
        architect = 2 * engineer;

        GameObject[] build2 = GameObject.FindGameObjectsWithTag("Engineer2");
         engineer = build1.Length;
        architect = 4 * engineer;
        
        GameObject[] build3 = GameObject.FindGameObjectsWithTag("Engineer3");
         engineer = build1.Length;
        architect = 6 * engineer;
        
    }
}
