using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
     public GameObject SquarePrefab;
    public Transform loadpoint;
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
     public void SpawnBuilding()
    {
        GameObject Square = Instantiate(SquarePrefab, loadpoint.position, loadpoint.rotation);
    }
    void Update()
    {
        
    }
}
