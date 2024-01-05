using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGen : MonoBehaviour
{
    [SerializeField] public int gold = 0;
    [SerializeField] public int collectgold = 0;
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
        GameObject[] Gens1 = GameObject.FindGameObjectsWithTag("Gold1");
        
        TimeInterval = TimeInterval + Time.deltaTime;
        
        int rhgens1 = Gens1.Length;

        if (TimeInterval >= time)
        {
            if (gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap)
            {
                collectgold += (1 * rhgens1);

            }
            TimeInterval = 0;
        }

        GameObject[] Gens2 = GameObject.FindGameObjectsWithTag("Gold2");

        
        int rhgens2 = Gens2.Length;

        if (TimeInterval >= time)
        {
            if (gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap)
            {
                collectgold += (2 * rhgens1);

            }
        }

        GameObject[] Gens3 = GameObject.FindGameObjectsWithTag("Gold3");

        
        int rhgens3 = Gens3.Length;

        if (TimeInterval >= time)
        {
            if (gold <= 9999999 && collectgold <= 9999999 && collectgold < collectCap)
            {
                collectgold += (3 * rhgens1);

            }
        }

    }
     private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            gold += collectgold;
           collectgold = 0;                 

           ResourceManager.gold = gold;
        } 

    }
}