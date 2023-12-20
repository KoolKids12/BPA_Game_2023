using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
     public GameObject SquarePrefab, temp;
    public Transform loadpoint;
    private Engineer engineer;
    private Vector3 loacte;
    private GameObject thing;
    void Start()
    {



    }

    // Update is called once per frame
     public void SpawnBuilding()
    {
        if(engineer.architect >= 1)
        {
             thing = Instantiate(temp, loadpoint.position, loadpoint.rotation);
            
            loacte = (temp.transform.position);

            engineer.architect--;

                Invoke(nameof(Maker), 5);

            
            
        }

    }
    void Maker()
    {
        engineer.architect++;

            Destroy(thing);
            GameObject thing1 = Instantiate(SquarePrefab, loacte, loadpoint.rotation);
    }
}
