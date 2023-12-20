using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyGen : MonoBehaviour
{
    [SerializeField] public int oxygen = 0;
    [SerializeField] public int collectoxygen = 0;
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
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Oxygen1");
        
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)
        {
            if (oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)
            {
                collectoxygen += (1 * rhgens1);

            }
            TimeInterval = 0;
        }

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Oxygen2");

        
        int rhgens2 = Gens2.Length;

        if (TimeInterval >= time)
        {
            if (oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)
            {
                collectoxygen += (2 * rhgens1);

            }
        }

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Oxygen3");

        
        int rhgens3 = Gens3.Length;

        if (TimeInterval >= time)
        {
            if (oxygen <= 9999999 && collectoxygen <= 9999999 && collectoxygen < collectCap)
            {
                collectoxygen += (3 * rhgens1);

            }
        }

    }
     private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            oxygen += collectoxygen;
           collectoxygen = 0;                 
        } 

    }
}