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


    // Update is called once per frame
    void Update()
    {
        if (Spawnable())
        {
        if (spawningEnabled1 == true && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false && ResourceManager.grunt >0) // only allows somethign to be spawnable if all is not spawnable
        {
            if (Input.GetMouseButtonDown(0)) // gets mouse button
            {
            SpawnTroop1();
            ResourceManager.grunt-=1; // subtracts from resources
            

            

            spawningEnabled1 = false; // disables spawning
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == true && spawningEnabled3 == false && spawningEnabled4 == false && ResourceManager.gobbler >0)
        {
            if (Input.GetMouseButtonDown(0)) // same as first
            {
            SpawnTroop2();
            ResourceManager.gobbler-=1;
            

            
            spawningEnabled2 = false;
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == true && spawningEnabled4 == false && ResourceManager.shocktrooper >0)
        {
            if (Input.GetMouseButtonDown(0)) // same as first
            {
            SpawnTroop3();
            ResourceManager.shocktrooper-=1;
            

            
            spawningEnabled3 = false;
            }
        }
        else if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == true && ResourceManager.mech >0)
        {
            if (Input.GetMouseButtonDown(0)) // same as first
            {
            SpawnTroop4();
            ResourceManager.mech -=1;
            

            
            spawningEnabled4 = false;
            }
        }
        }
    }

    public void Button1Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false) // if everything is false then this can be true
        {
            spawningEnabled1 = true;
        }
        else// disables it
        {
            spawningEnabled1 = false;
        }
    }

    public void Button2Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)// if everything is false then this can be true
        {
            spawningEnabled2 = true;
        }
        else// disables it
        {
            spawningEnabled2 = false;
        }
    }

    public void Button3Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)// if everything is false then this can be true
        {
            spawningEnabled3 = true;
        }
        else// disables it
        {
            spawningEnabled3 = false;
        }
    }

    public void Button4Click()
    {
        if (spawningEnabled1 == false && spawningEnabled2 == false && spawningEnabled3 == false && spawningEnabled4 == false)// if everything is false then this can be true
        {
            spawningEnabled4 = true;
        }
        else// disables it
        {
            spawningEnabled4 = false;
        }
    }

    void SpawnTroop1()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(GruntPrefab, spawnPosition, Quaternion.identity); // summons grunt
        Objectcreated.transform.Rotate(0, 0, 0);
        
        var GruntComponent = Objectcreated.AddComponent<Grunt>(); // gives scripts
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        GruntComponent.SetTroop(troopcomponent);
    }
    void SpawnTroop2()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        var Objectcreated = Instantiate(GobblerPrefab, spawnPosition, Quaternion.identity); // summons gobbler
        Objectcreated.transform.Rotate(0, 0, 0);
        var gobblerComponent = Objectcreated.AddComponent<Gobbler>();// gives scripts
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        gobblerComponent.SetTroop(troopcomponent);
    }

    void SpawnTroop3()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(ShocktrooperPrefab, spawnPosition, Quaternion.identity); // summons shocktrooper
        Objectcreated.transform.Rotate(0, 0, 0);
        var ShockTrooperComponent = Objectcreated.AddComponent<ShockTrooper>();// gives scripts
        var troopcomponent = Objectcreated.AddComponent<Troop>();

        ShockTrooperComponent.SetTroop(troopcomponent);
        ShockTrooperComponent.SetPrefab(GobblerPrefab);
    }

    void SpawnTroop4()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var Objectcreated = Instantiate(GiantPrefab, spawnPosition, Quaternion.identity); // summon mech
        Objectcreated.transform.Rotate(0, 0, 0);
        Objectcreated.tag = "Troop";
        
        var GiantComponent = Objectcreated.AddComponent<Giant>();// gives scripts
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        
        GiantComponent.SetTroop(troopcomponent);
    }

    public bool Spawnable() // if it is within 1 length of any objects in the scene then it cannot spawn there.
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0f;
        Vector2 circle = Camera.main.ScreenToWorldPoint(mousePosition);
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(circle, 1f);

        if (hitColliders.Length == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}