using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMasher : MonoBehaviour
{
    [SerializeField] public BuildingProperties masher;
    [SerializeField] public float Attackcooldown = 0.1f;
    private float nextAttackTime = 0f;
    [SerializeField] public Vector3 Center;
    public float attackRadius = 2f;

    private void Awake()
    {
        Center = transform.position;
        masher.maxhealth = 4;
    }

    private void OnCollisionEnter2D(Collision2D other) // on collision
    {
        if (Time.time >= nextAttackTime) // checks cooldown
        {
            MashDamage(Center, attackRadius); // deal damage to all troops near it
            nextAttackTime = Attackcooldown + Time.time; // adds to timer
        }
    }
    private void OnCollisionStay2D(Collision2D other) 
    {
        if (Time.time >= nextAttackTime) // checks cooldown
        {
            MashDamage(Center, attackRadius);// deals damage to troops around them
            nextAttackTime = Attackcooldown + Time.time; // adds totimer
        }
    }

    void MashDamage(Vector3 center, float radius)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius); // all things that get hit within a 1 radius circle
        foreach (var hitCollider in hitColliders)
        {
            Troop troop = hitCollider.gameObject.GetComponent<Troop>(); // gets troop from objects collided

            if (troop != null) // checks if they exist
            {
                troop.TakeDamage(5f); // deals damage to troops
            }
            else{}
        }
    }
}