using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockTrooper : MonoBehaviour
{
    [SerializeField] public Troop Shocktrooper;
    public GameObject GobblerPrefab;
    private BoxCollider2D myCollider;
    public void SetTroop(Troop ShockTrooperr) // gets shocktrooper
    {
        Shocktrooper = ShockTrooperr;
        myCollider = GetComponent<BoxCollider2D>();
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3; // changes speed of shocktrooper

        if (Shocktrooper != null)
        {
            Shocktrooper.maxhealth = 9; // gives helth
            Shocktrooper.currenthealth = Shocktrooper.maxhealth;
            Shocktrooper.dealdamage = 1.5f; // sets damage
        }
    } 
    public void SetPrefab(GameObject gobbler) // sets the gobbler prefab to summon gobbler
    {
        GobblerPrefab = gobbler;
    }

    
    private void OnDestroy() 
    {
        Vector3 spawnPosition = transform.position; // sets the spawn position to the last point of shocktrooper
        var Objectcreated = Instantiate(GobblerPrefab, spawnPosition, Quaternion.identity); // summons gobbler
        var gobblerComponent = Objectcreated.AddComponent<Gobbler>(); // gives it scripts
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        gobblerComponent.SetTroop(troopcomponent);
        Objectcreated.transform.rotation = Quaternion.identity;
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Wall") // lets it jump over walls
        {
            myCollider.isTrigger = true;
        }
        else 
        {
            myCollider.isTrigger = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collider) 
    {
        if(collider.gameObject.tag == "Wall") // lets it jump over walls
        {
            myCollider.isTrigger = true;
        }
        else 
        {
            myCollider.isTrigger = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        myCollider.isTrigger = false; // after it jumps over wall. re enables the collider
    }
}
