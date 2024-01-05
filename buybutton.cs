using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
     public GameObject SquarePrefab, temp;
    public Transform loadpoint;
    private Vector3 loacte;
    private GameObject thing;
    void Start()
    {



    }

    // Update is called once per frame
     public void SpawnBuilding()
    {
        if(ResourceManager.architect >= 1)
        {
             thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);
            

            ResourceManager.architect--;

                Invoke(nameof(Maker), 5);

            
            
        }

    }
    void Maker()
    {
        ResourceManager.architect++;

            Destroy(thing);
            GameObject thing1 = Instantiate(SquarePrefab, loadpoint.position, loadpoint.rotation);
    }
}
