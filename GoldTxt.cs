using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldTxt : MonoBehaviour
{

    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        txt.text = ResourceManager.gold.ToString();


    }
}
