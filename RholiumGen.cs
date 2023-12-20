using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RholiumGen : MonoBehaviour
{
    [SerializeField] public int refinedholium = 0;
    [SerializeField] public int total = 0;
    [SerializeField] public int collectrefinedholium = 0;
    [SerializeField] private int collectCap = 20;
    float TimeInterval;
    [SerializeField] float time=3;
    private ResourceManager recourceManager;
    // Start is called before the first frame update
    void Start()
    {
        refinedholium = total;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("RefinedHolium1");
        
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)
        {
            if (refinedholium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)
            {
                collectrefinedholium += (1 * rhgens1);

            }
            TimeInterval = 0;
        }

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("RefinedHolium2");

        
        int rhgens2 = Gens2.Length;

        if (TimeInterval >= time)
        {
            if (refinedholium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)
            {
                collectrefinedholium += (2 * rhgens1);

            }
        }

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("RefinedHolium3");

        
        int rhgens3 = Gens3.Length;

        if (TimeInterval >= time)
        {
            if (refinedholium <= 9999999 && collectrefinedholium <= 9999999 && collectrefinedholium < collectCap)
            {
                collectrefinedholium += (3 * rhgens1);

            }
        }
        
       
    }
    private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {  
            refinedholium += collectrefinedholium;
           collectrefinedholium = 0;               
           recourceManager.refinedHolium = refinedholium;  
            
        } 
    }
     
}