using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit : MonoBehaviour
{
    [SerializeField] private Camera camera;
    public GameObject otherobj;
    public string scr;
    private Vector3 placement;
    void Start()
    {
        (otherobj.GetComponent(scr) as MonoBehaviour).enabled = false;
        
    }

    void Update()  
    {
        placement = camera.ViewportToWorldPoint(new Vector3(1,1,camera.nearClipPlane));

        transform.position = placement;
    }

private void OnMouseDown() 
{
        (otherobj.GetComponent(scr) as MonoBehaviour).enabled = true;
    
    Debug.Log("Clicked");
}

}
