using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockTrooper : MonoBehaviour
{
    [SerializeField] public Troop Shocktrooper;
    public GameObject GobblerPrefab;
    private BoxCollider2D myCollider;
    public void SetTroop(Troop ShockTrooperr)
    {
        Shocktrooper = ShockTrooperr;
        myCollider = GetComponent<BoxCollider2D>();
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 4;

        if (Shocktrooper != null)
        {
            Shocktrooper.maxhealth = 9;
            Shocktrooper.currenthealth = Shocktrooper.maxhealth;
            Shocktrooper.dealdamage = 1.5f;
        }
    } 
    public void SetPrefab(GameObject gobbler)
    {
        GobblerPrefab = gobbler;
    }

    
    private void OnDestroy() 
    {
        Vector3 spawnPosition = transform.position;
        var Objectcreated = Instantiate(GobblerPrefab, spawnPosition, Quaternion.identity);
        var gobblerComponent = Objectcreated.AddComponent<Gobbler>();
        var troopcomponent = Objectcreated.AddComponent<Troop>();
        gobblerComponent.SetTroop(troopcomponent);
        Objectcreated.transform.rotation = Quaternion.identity;
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Wall")
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
        if(collider.gameObject.tag == "Wall")
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
        myCollider.isTrigger = false;
    }
}