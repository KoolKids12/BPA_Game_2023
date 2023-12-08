using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSeige : MonoBehaviour
{
    public GameObject gameObject;
    public Transform placement;
    private Vector3 scaleChange;
    public GameObject button;
   public void seigeInitate()
   {
        GameObject Triangle = Instantiate(gameObject, placement.position, placement.rotation);
       
        scaleChange = new Vector3(-1f, -1f, -0f);
        button.transform.localScale += scaleChange;
   }
}
