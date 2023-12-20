using UnityEngine;

public class BomberSquare : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    public float minDistanceToWall = 2f; // Adjust the minimum distance as needed
     public float damage = 2f;
    public float attackInterval = 2f;
    

    private GameObject[] walls; // List of available Wall GameObjects
    private GameObject currentTarget; // The current targeted Wall

    // Start is called before the first frame update
    void Start()
    {
        FindWalls();
        FindClosestWall();
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveToWall();
    }

    void MoveToWall()
    {
        if (currentTarget != null)
        {
            // Check the distance between the Bomber and the current target
            float distanceToWall = Vector3.Distance(transform.position, currentTarget.transform.position);

            // Only move towards the current target if the distance is greater than the minimum distance
            if (distanceToWall > minDistanceToWall)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, moveSpeed * Time.deltaTime);
            }
        }
    }

    void FindWalls()
    {
        // Find all Wall GameObjects in the scenes
        walls = GameObject.FindGameObjectsWithTag("Wall");
        
    }

    
   void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    void FindClosestWall()
    {
        float closestDistance = float.MaxValue;

        foreach (GameObject wall in walls)
        {
            float distanceToWall = Vector3.Distance(transform.position, wall.transform.position);

            if (distanceToWall < closestDistance)
            {
                closestDistance = distanceToWall;
                currentTarget = wall;
                
            }
           
            
            
            
        }
    }
     
}
