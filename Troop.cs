using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Troop : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public LayerMask unwalkableMask;
    public float checkRadius = 1f;
    public float attackInterval = 1.3f; // Set the attack cooldown
    private float nextAttackTime;

    [SerializeField] public int maxhealth = 5;
    [SerializeField] public int currenthealth;

    void Start()
    {
        currenthealth = maxhealth;

        target = GameObject.FindGameObjectWithTag("Building").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        SetDefenseTarget(); // Set an initial target
        
    }

    void Update()
    {
        if (agent.enabled)
        {
        if (agent.remainingDistance < 0.5f) // If close to the target or reached the destination
        {
            SetDefenseTarget();
        }
        
        CheckUnwalkableObjects();
        }
    }

    void SetDefenseTarget()
    {
        GameObject defenseObject = GameObject.FindGameObjectWithTag("Building");

        if (defenseObject != null)
        {
            target = defenseObject.transform;
            agent.SetDestination(target.position);
        }
        else
        {
            agent.enabled = false;
        }
    }

    void CheckUnwalkableObjects()
    {
        if (agent.enabled)
        {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, checkRadius, unwalkableMask);

        foreach (var hitCollider in hitColliders)
        {
            // Check if the unwalkable object is destroyed
            if (hitCollider == null)
            {
                // If destroyed, recalculate the path
                agent.ResetPath();
                SetDefenseTarget();
                break;
            }
        }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (agent.enabled)
        {
        BuildingProperties buildingComponent = collision.gameObject.GetComponent<BuildingProperties>(); // find the object it collided with
        
        if (buildingComponent != null)
        {
            buildingComponent.TakeDamage(1); // Send damage to the TakeDamage function of collided object
            nextAttackTime = Time.time + attackInterval; // resets the attack timer
        }
        else
        {
        }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(agent.enabled)
        {
        BuildingProperties buildingComponent = collision.gameObject.GetComponent<BuildingProperties>(); // find the object it collided with

        
        if (buildingComponent != null)
        {
            if (Time.time >= nextAttackTime) // checks if it can attack again based on attack time
            {            
                buildingComponent.TakeDamage(1); // Send damage to the TakeDamage function of collided object

                nextAttackTime = Time.time + attackInterval; // resets attack timer

            }
        }
        else
        {

        }
        }
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}


