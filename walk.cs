using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    public float minDistanceToHouse = 2f; // Adjust the minimum distance as needed
    public float attackInterval = 2f; // Time between attacks
    private List<Triangle> houses = new List<Triangle>(); // List of available Triangle scripts
    private Triangle currentHouse; // The current targeted house
    private bool isAttacking = false; // Flag to check if the square is currently attacking

    // Start is called before the first frame update
    void Start()
    {
        FindHouses();
        FindClosestHouse();
        StartCoroutine(AttackHouse());
    }

    // Update is called once per frame
    void Update()
    {
        MoveToHouse();
    }

    void MoveToHouse()
    {
        if (currentHouse != null && !isAttacking)
        {
            // Check the distance between the square and the current house
            float distanceToHouse = Vector3.Distance(transform.position, currentHouse.transform.position);

            // Only move towards the current house if the distance is greater than the minimum distance
            if (distanceToHouse > minDistanceToHouse)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentHouse.transform.position, moveSpeed * Time.deltaTime);
            }
        }
    }

    void FindHouses()
    {
        // Find all Triangle scripts in the scene
        Triangle[] houseArray = FindObjectsOfType<Triangle>();

        if (houseArray.Length > 0)
        {
            houses.AddRange(houseArray);
        }
        else
        {
            Debug.LogError("No houses (Triangle scripts) found in the scene.");
        }
    }

    void FindClosestHouse()
    {
        float closestDistance = float.MaxValue;

        foreach (Triangle house in houses)
        {
            float distanceToHouse = Vector3.Distance(transform.position, house.transform.position);

            if (distanceToHouse < closestDistance)
            {
                closestDistance = distanceToHouse;
                currentHouse = house;
            }
        }
    }

    IEnumerator AttackHouse()
    {
        while (true)
        {
            yield return new WaitForSeconds(attackInterval);

            // Attack the current house if it's still present and the square is close enough
            if (currentHouse != null && !isAttacking)
            {
                float distanceToHouse = Vector3.Distance(transform.position, currentHouse.transform.position);

                if (distanceToHouse <= minDistanceToHouse)
                {
                    isAttacking = true;
                    currentHouse.TakeDamage(1);
                    isAttacking = false;
                }
            }
        }
    }
}
