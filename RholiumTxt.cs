using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RholiumTxt : MonoBehaviour
{
    public TextMeshProUGUI txt;
    [SerializeField] public RholiumGen refinedHoliumGen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        txt.text = refinedHoliumGen.refinedholium.ToString();


    }
}
