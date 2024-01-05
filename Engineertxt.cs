using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Engineertxt : MonoBehaviour
{
    public TextMeshProUGUI txt;

    void Update()
    { 
        txt.text = ResourceManager.architect.ToString();
      }
    
}
