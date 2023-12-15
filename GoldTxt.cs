using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GoldTxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private GoldGen goldGen;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { GameObject gameObject;
      gameObject = GameObject.FindGameObjectWithTag("Gold1");

      goldGen = gameObject.GetComponent<GoldGen>();
        
       
        txt.text = goldGen.gold.ToString();


    }
}