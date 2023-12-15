using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoalTxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private CoalGen coalGen;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { GameObject gameObject;
      gameObject = GameObject.FindGameObjectWithTag("Coal1");

      coalGen = gameObject.GetComponent<CoalGen>();
        txt.text = coalGen.coal.ToString();


    }
}