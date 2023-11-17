using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
    public GameObject SpawnGrunt;
    public GameObject SpawnHogRider;
    public GameObject SpawnArmVikingGuy;

    public GameObject GruntPrefab;
    public GameObject HogRiderPrefab;
    public GameObject ArmVikingGuyPrefab;
    [SerializeField] public bool spawningEnabled1 = false;
    [SerializeField] public bool spawningEnabled2 = false;
    [SerializeField] public bool spawningEnabled3 = false;

    [SerializeField] int clicksRemaining1 = 0;
    [SerializeField] int clicksRemaining2 = 0;
    [SerializeField] int clicksRemaining3 = 0;


    // Update is called once per frame
    void Update()
    {
        if (spawningEnabled1 == true && spawningEnabled2 == false && spawningEnabled3 == false && clicksRemaining1 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop1();
            clicksRemaining1--;
            

            if (clicksRemaining1 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled1 = false;
            }
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == true && spawningEnabled3 == false && clicksRemaining2 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop2();
            clicksRemaining2--;
            

            if (clicksRemaining2 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled2 = false;
            }
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == true && clicksRemaining1 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop3();
            clicksRemaining3--;
            

            if (clicksRemaining3 == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled3 = false;
            }
            }
        }
        else
        {
            spawningEnabled1 = false;
            spawningEnabled2 = false;
            spawningEnabled3 = false;
        }
    }

    public void Button1Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false)
        {
            spawningEnabled1 = true;
            clicksRemaining1 = 10;
        }
        else
        {
            spawningEnabled1 = false;
        }
    }

    public void Button2Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false)
        {
            spawningEnabled2 = true;
            clicksRemaining2 = 10;
        }
        else
        {
            spawningEnabled2 = false;
        }
    }

    public void Button3Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false)
        {
            spawningEnabled3 = true;
            clicksRemaining3 = 10;
        }
        else
        {
            spawningEnabled3 = false;
        }
    }

    void SpawnTroop1()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(GruntPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnTroop2()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(HogRiderPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnTroop3()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(ArmVikingGuyPrefab, spawnPosition, Quaternion.identity);
    }
}