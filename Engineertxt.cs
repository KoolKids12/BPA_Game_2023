using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Engineertxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private Engineer engineerGen;

    void Update()
    { GameObject gameObject, gameObject1, gameObject2;
      
      gameObject = GameObject.FindGameObjectWithTag("Engineer1");
      if(gameObject != null)
      {
      engineerGen = gameObject.GetComponent<Engineer>();
        
       
        txt.text = engineerGen.architect.ToString();
      }
      gameObject1 = GameObject.FindGameObjectWithTag("Engineer2");
      if(gameObject1 != null)
      {
        engineerGen = gameObject.GetComponent<Engineer>();
        
       
        txt.text = engineerGen.architect.ToString();
      }

      gameObject2 = GameObject.FindGameObjectWithTag("Engineer3");
      if(gameObject2 != null)
      {
        engineerGen = gameObject.GetComponent<Engineer>();
        
       
        txt.text = engineerGen.architect.ToString();
      }
    }
}
