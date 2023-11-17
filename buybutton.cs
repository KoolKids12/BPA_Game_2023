using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
    public GameObject = SpawnGrunt;
    public GameObject = SpawnHogRider;
    public GameObject = SpawnArmVikingGuy;

    public GameObject SquarePrefab;
    [SerializeField] public bool spawningEnabled1 = false;
    [SerializeField] public bool spawningEnabled2 = false;
    [SerializeField] public bool spawningEnabled3 = false;

    [SerializeField] int clicksRemaining1 = 0;
    [SerializeField] int clicksRemaining2 = 0;
    [SerializeField] int clicksRemaining3 = 0;


    // Update is called once per frame
    void Update()
    {
        if (spawningEnabled1 && clicksRemaining1 > 0 && Input.GetMouseButtonDown(0))
        {
            SpawnBuilding();
            clicksRemaining1--;

            if (clicksRemaining1 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled1 = false;
            }
        }
        else if (spawningEnabled2 && clicksRemaining2 > 0 && Input.GetMouseButtonDown(0))
        {
            SpawnBuilding();
            clicksRemaining2--;

            if (clicksRemaining2 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled2 = false;
            }
        }
        else if (spawningEnabled3 && clicksRemaining3 > 0 && Input.GetMouseButtonDown(0))
        {
            SpawnBuilding();
            clicksRemaining3--;

            if (clicksRemaining3 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled3 = false;
            }
        }
    }

    public void ButtonGrunt()
    {
        if (gameObject.tag == "GruntSpawn")
        {
            spawningEnabled1 = true;
            spawningEnabled2 = false;
            spawningEnabled3 = false;
        }
    }

    public void ButtonHogRider()
    {
        if (gameObject.tag == "HogRiderSpawn")
        {
            spawningEnabled1 = false;
            spawningEnabled2 = true;
            spawningEnabled3 = false;
        }
    }

    public void ButtonArmVikingGuy()
    {
        if (gameObject.tag == "ArmVikingGuySpawn")
        {
            spawningEnabled1 = false;
            spawningEnabled2 = false;
            spawningEnabled3 = true;
        }
    }

    void SpawnBuilding()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(SquarePrefab, spawnPosition, Quaternion.identity);
    }
}