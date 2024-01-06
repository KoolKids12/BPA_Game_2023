using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant : MonoBehaviour
{
    [SerializeField] public Troop giant;

    public void SetTroop(Troop gint)
    {
        giant = gint;
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 0.5f;

        if (giant != null)
        {
            giant.maxhealth = 15;
            giant.currenthealth = giant.maxhealth;
            giant.dealdamage = 3;
        }
    }

    private void Start()
    {
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1f;

        if (giant != null)
        {
            giant.maxhealth = 15;
            giant.currenthealth = giant.maxhealth;
            giant.dealdamage = 3;
        }
    }
}
