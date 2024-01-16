using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobbler : MonoBehaviour
{
    [SerializeField] public Troop gobbler;

    public void SetTroop(Troop gobblerr) // gets gobbler
    {
        gobbler = gobblerr; // sets gobbler
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 4; // sets speed
        gobbler.dealdamage = 0.5f; // sets damage

        if (gobbler != null) // checks if gobbler is null
        {
            gobbler.maxhealth = 6;
            gobbler.currenthealth = gobbler.maxhealth;
        }
    }
}