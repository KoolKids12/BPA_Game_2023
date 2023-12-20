using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OxyTxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
   private OxyGen oxyGen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       GameObject gameObject;
      gameObject = GameObject.FindGameObjectWithTag("Oxygen1");

      oxyGen = gameObject.GetComponent<OxyGen>();
        
        txt.text = oxyGen.oxygen.ToString();


    }
}