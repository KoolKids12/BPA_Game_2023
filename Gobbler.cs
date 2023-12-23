using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobbler : MonoBehaviour
{
    [SerializeField] public Troop gobbler;

    public void SetTroop(Troop gobblerr)
    {
        gobbler = gobblerr;
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 4;
        gobbler.dealdamage = 0.5f;

        if (gobbler != null)
        {
            gobbler.maxhealth = 6;
            gobbler.currenthealth = gobbler.maxhealth;
        }
    }
}