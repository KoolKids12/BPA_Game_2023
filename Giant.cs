using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant : MonoBehaviour
{
    [SerializeField] public Troop giant;

    public void SetTroop(Troop gint) // gets the troop
    {
        giant = gint;
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1f; // changes speed

        if (giant != null) // checks if giant is there
        {
            giant.maxhealth = 15;
            giant.currenthealth = giant.maxhealth;
            giant.dealdamage = 3;
        }
    }

    private void Start()
    {
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1f; // changes speed

        if (giant != null) // checks if giant is null
        {
            giant.maxhealth = 15;
            giant.currenthealth = giant.maxhealth;
            giant.dealdamage = 3;
        }
    }
}
