using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public GameObject SpawnGrunt;
    public GameObject SpawnHogRider;
    public GameObject ArmVikingGuy;
    public GameObject SpawnGiant;
    public GameObject GruntPrefab;
    public GameObject GobblerPrefab;
    public GameObject ShocktrooperPrefab;
    public GameObject GiantPrefab;
    [SerializeField] public bool spawningEnabled1 = false;
    [SerializeField] public bool spawningEnabled2 = false;
    [SerializeField] public bool spawningEnabled3 = false;
    [SerializeField] public bool spawningEnabled4 = false;

    [SerializeField] int clicksRemaining1 = 0;
    [SerializeField] int clicksRemaining2 = 0;
    [SerializeField] int clicksRemaining3 = 0;
    [SerializeField] int clicksRemaining4 = 0;


    // Update is called once per frame
    void Update()
    {
        if (Spawnable())
        {
        if (spawningEnabled1 == true && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false && clicksRemaining1 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop1();
            clicksRemaining1--;
            

            if (clicksRemaining1 == 0)
            {
                spawningEnabled1 = false;
            }

            spawningEnabled1 = false;
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == true && spawningEnabled3 == false && spawningEnabled4 == false && clicksRemaining2 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop2();
            clicksRemaining2--;
            

            if (clicksRemaining2 == 0)
            {
                spawningEnabled2 = false;
            }
            spawningEnabled2 = false;
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == true && spawningEnabled4 == false && clicksRemaining3 >0)
        {
            if (Input.GetMouseButtonDown(0))
            {
            SpawnTroop3();
            clicksRemaining3--;
            

            if (clicksRemaining3 == 0)
            {
                spawningEnabled3 = false;
            }
            spawningEnabled3 = false;
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == true && clicksRemaining4 >0)
        {
            Debug.Log("all false");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("input");
            SpawnTroop4();
            clicksRemaining4--;
            

            if (clicksRemaining4 == 0)
            {
                spawningEnabled4 = false;
            }
            spawningEnabled4 = false;
            }
        }
        }
    }

    public void Button1Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)
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
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)
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
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)
        {
            spawningEnabled3 = true;
            clicksRemaining3 = 10;
        }
        else
        {
            spawningEnabled3 = false;
        }
    }

    public void Button4Click()
    {
        Debug.Log("click");
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)
        {
            Debug.Log("spawningenabled");
            spawningEnabled4 = true;
            clicksRemaining4 = 10;
        }
        else
        {
            spawningEnabled4 = false;
        }
    }

    void SpawnTroop1()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(GruntPrefab, spawnPosition, Quaternion.identity);
        Objectcreated.transform.Rotate(0, 0, 0);
        
        var GruntComponent = Objectcreated.AddComponent<Grunt>();
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        GruntComponent.SetTroop(troopcomponent);
    }
    void SpawnTroop2()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        var Objectcreated = Instantiate(GobblerPrefab, spawnPosition, Quaternion.identity);
        Objectcreated.transform.Rotate(0, 0, 0);
        var gobblerComponent = Objectcreated.AddComponent<Gobbler>();
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        gobblerComponent.SetTroop(troopcomponent);
    }

    void SpawnTroop3()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(ShocktrooperPrefab, spawnPosition, Quaternion.identity);
        Objectcreated.transform.Rotate(0, 0, 0);
        var ShockTrooperComponent = Objectcreated.AddComponent<ShockTrooper>();
        var troopcomponent = Objectcreated.AddComponent<Troop>();

        ShockTrooperComponent.SetTroop(troopcomponent);
        ShockTrooperComponent.SetPrefab(GobblerPrefab);
    }

    void SpawnTroop4()
    {
        Debug.Log("Spawn");
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(GiantPrefab, spawnPosition, Quaternion.identity);
        Objectcreated.transform.Rotate(0, 0, 0);
        Objectcreated.tag = "Troop";
        
        var GiantComponent = Objectcreated.AddComponent<Giant>();
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        GiantComponent.SetTroop(troopcomponent);
    }

    public bool Spawnable()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0f;
        Vector2 circle = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(circle, 1f);

        if (hitColliders.Length > 0)
        {
            // There are colliders, so the location is not spawnable
            return false;
        }
        else 
        {
            // No colliders, so the location is spawnable
            return true;
        }
    }
}