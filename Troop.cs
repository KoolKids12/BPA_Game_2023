using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Troop : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;//is target
    public LayerMask unwalkableMask;
    public float checkRadius = 1f;
    public float attackInterval = 1.3f; // Set the attack cooldown
    private float nextAttackTime; // times the next attack
    [SerializeField] public float maxhealth = 5; // sets base health for troop
    [SerializeField] public float currenthealth;// sets the current health
    [SerializeField] public float dealdamage;
    public SaveAndLoad saveAndLoad;

    void Awake()
    {
        gameObject.GetComponent<NavMeshAgent>().speed = 2; // makes speed not super fast
    }
    
    void Start()
    {
        currenthealth = maxhealth; // sets currnt helthh to max
        target = GameObject.FindGameObjectWithTag("Building").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        gameObject.transform.rotation = Quaternion.identity;
        SetDefenseTarget(); // Set an initial target
        saveAndLoad = FindObjectOfType<SaveAndLoad>();
        
    }

    void Update()
    {
        if (agent.enabled == true)
        {
        if (agent.remainingDistance < 0.5f) // If close to the target or reached the destination ... this was for initial testing but i never removed and it doesnt do anything
        {
            SetDefenseTarget();
        }
        
        CheckUnwalkableObjects();
        }
        if(ResourceManager.grunt <=0 && ResourceManager.gobbler <=0 && ResourceManager.shocktrooper <=0 && ResourceManager.mech <=0) // if you lose all your troops it takes you to startscreen
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
    void SetDefenseTarget() // finds objects in scene for the troops to attack
    {
        List<GameObject> defenselist = new List<GameObject>();
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Building"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Pumpkin"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Masher"));
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("Ballista"));
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
        defenselist.AddRange(GameObject.FindGameObjectsWithTag("RefinedHolium3")); // these lines add all the tags of possible buildings for targets (not walls)

        GameObject[] defenseObjects = defenselist.ToArray(); // makes it an array not 

        if (defenseObjects.Length > 0) // if there are targets
        {
            float shortestDistance = float.MaxValue; // BIG
            Transform closestDefenseObject = null;

            for (int i = 0; i < defenseObjects.Length; i++) // these for loops v
            {
                for (int x = 0; x < defenseObjects.Length; x++) // calculate the shortest target to go there
                {
                    if (i == x && defenseObjects.Length > 1) // skip comparing an object to itself
                    {
                        continue;
                    }
                    
                    float distance = Vector3.Distance(transform.position, defenseObjects[i].transform.position);// calculate the distance between the agent and each object
                
                    if (distance <= shortestDistance) // checks if target is closer than the current closest target
                    {
                        shortestDistance = distance;
                        closestDefenseObject = defenseObjects[i].transform;// update the closest object if the current distance is shorter
                    }
                }
            }

            if (closestDefenseObject != null) // checks if it exists
            {
                target = closestDefenseObject;
                agent.SetDestination(target.position);
            }
            else
            {
                agent.enabled = false; // if it doesn't exist there are no targets and turns off the agent
            }
        }
        else
        {
            agent.enabled = false;
            Scene scene = SceneManager.GetActiveScene();
            

            SceneManager.LoadScene("HomeBaseLevelOne");
            saveAndLoad.LoadGame();
            
            if(scene.name == "AttackBase1")
                {
                    ResourceManager.gold += 10;
                    ResourceManager.coal += 10;
                    ResourceManager.oxygen += 10;
                    ResourceManager.refinedHolium += 10;
                }
                else if(scene.name == "AttackBase2")
                {
                    ResourceManager.gold += 20;
                    ResourceManager.coal += 20;
                    ResourceManager.oxygen += 20;
                    ResourceManager.refinedHolium += 20;
                }
                else if(scene.name == "AttackBase3")
                {
                    ResourceManager.gold += 30;
                    ResourceManager.coal += 30;
                    ResourceManager.oxygen += 30;
                    ResourceManager.refinedHolium += 30;
                }
                else if(scene.name == "AttackBase4")
                {
                    ResourceManager.gold += 40;
                    ResourceManager.coal += 40;
                    ResourceManager.oxygen += 40;
                    ResourceManager.refinedHolium += 40;
                }
                else if(scene.name == "AttackBase5")
                {
                    ResourceManager.gold += 50;
                    ResourceManager.coal += 50;
                    ResourceManager.oxygen += 50;
                    ResourceManager.refinedHolium += 50;
                }
        }
    }
    void CheckUnwalkableObjects() // allows / disallows certain areas to be walked on
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

    public void TakeDamage(float damage) // allows the troop to take damage when hit
    {
        currenthealth -= damage;

        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}


