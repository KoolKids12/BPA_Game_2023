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
    [SerializeField] public float maxhealth = 5;
    [SerializeField] public float currenthealth;
    [SerializeField] public float dealdamage;


    void Awake()
    {
        gameObject.GetComponent<NavMeshAgent>().speed = 2;
    }
    
    void Start()
    {
        currenthealth = maxhealth;
        target = GameObject.FindGameObjectWithTag("Building").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        gameObject.transform.rotation = Quaternion.identity;
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
        List<GameObject> defenselist = new List<GameObject>();
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Building"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Coal1"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Coal2"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Coal3"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Gold1"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Gold2"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Gold3"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Oxygen1"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Oxygen2"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Oxygen3"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("RefinedHolium1"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("RefinedHolium2"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("RefinedHolium3"));

        GameObject[] defenseObjects = defenselist.ToArray();

        if (defenseObjects.Length > 0)
        {
            float shortestDistance = float.MaxValue; // BIG
            Transform closestDefenseObject = null;

            for (int i = 0; i < defenseObjects.Length; i++)
            {
                for (int x = 0; x < defenseObjects.Length; x++)
                {
                    if (i == x) // Skip comparing an object to itself
                    {
                        continue;
                    }
                    // Calculate the distance between the agent and each object
                    float distance = Vector3.Distance(transform.position, defenseObjects[i].transform.position);
                
                    // Update the closest object if the current distance is shorter
                    if (distance <= shortestDistance)
                    {
                        shortestDistance = distance;
                        closestDefenseObject = defenseObjects[i].transform;
                    }
                }
            }

            if (closestDefenseObject != null)
            {
                target = closestDefenseObject;
                agent.SetDestination(target.position);
            }
            else
            {
                agent.enabled = false;
            }
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
                buildingComponent.TakeDamage(dealdamage); // Send damage to the TakeDamage function of collided object

                nextAttackTime = Time.time + attackInterval; // resets attack timer

            }
        }
        else
        {

        }
        }
    }

    public void TakeDamage(float damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}


