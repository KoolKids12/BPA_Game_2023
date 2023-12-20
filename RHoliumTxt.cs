using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RHoliumTxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
   private RholiumGen rholiumGenGen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GameObject gameObject;
      gameObject = GameObject.FindGameObjectWithTag("RefinedHolium1");

      rholiumGenGen = gameObject.GetComponent<RholiumGen>();
      
        txt.text = rholiumGenGen.refinedholium.ToString();


    }
}