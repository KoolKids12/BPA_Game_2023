using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTimer : MonoBehaviour
{
    public int clicktimer = 0;
    private Upgrades upgrades;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clicktimer++;
    }
      
    private void OnMouseOver() 
    {
        if (Input.GetMouseButtonDown(0))
        {             
            Debug.Log(clicktimer);
            clicktimer = 0;
            Debug.Log(gameObject);
            upgrades = GameObject.FindObjectOfType<Upgrades>();
            upgrades.clickedon(gameObject);

        } 

    }

}
