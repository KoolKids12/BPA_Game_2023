using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalGen : MonoBehaviour
{
    [SerializeField] public int coal = 0;
    [SerializeField] public int collectcoal = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Coal1");
        
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)
        {
            if (coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)
            {
                collectcoal += (1 * rhgens1);

            }
            TimeInterval = 0;
        }

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Coal2");

        
        int rhgens2 = Gens2.Length;

        if (TimeInterval >= time)
        {
            if (coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)
            {
                collectcoal += (2 * rhgens1);

            }
        }

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Coal3");

        
        int rhgens3 = Gens3.Length;

        if (TimeInterval >= time)
        {
            if (coal <= 9999999 && collectcoal <= 9999999 && collectcoal < collectCap)
            {
                collectcoal += (3 * rhgens1);

            }
        }
    }
     private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            coal = collectcoal;

            ResourceManager.coal += coal;
           collectcoal = 0;                 
        } 

    }
}