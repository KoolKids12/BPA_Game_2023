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

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (Time.time >= nextAttackTime)
        {
            MashDamage(Center, attackRadius);
            nextAttackTime = Attackcooldown + Time.time;
        }
    }
    private void OnCollisionStay2D(Collision2D other) 
    {
        if (Time.time >= nextAttackTime)
        {
            MashDamage(Center, attackRadius);
            nextAttackTime = Attackcooldown + Time.time;
        }
    }

    void MashDamage(Vector3 center, float radius)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius);
        foreach (var hitCollider in hitColliders)
        {
            Troop troop = hitCollider.gameObject.GetComponent<Troop>();

            if (troop != null)
            {
                troop.TakeDamage(5f);
            }
            else{}
        }
    }
}