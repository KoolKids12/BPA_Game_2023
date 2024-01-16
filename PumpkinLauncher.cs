using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLauncher : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public BuildingProperties pumpkinlauncher;
    Vector2 moveDirection;
    Vector2 mousePosition;
    public float moveSpeed = 5f;
    public Pumpkin pumpkin;
    public GameObject[] targets;
    public float minrange = 10f;
    public float maxrange = 60f;
    [SerializeField] public float Attackcooldown = 5f;
    private float timer;

    private void Awake()
    {
        pumpkinlauncher.maxhealth = 6; // sets health
    }

    public void Update()
    {
        timer += Time.deltaTime; // adds time to timer
        targets = GameObject.FindGameObjectsWithTag("Troop"); // finds troops to attack

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized; // sets direction to fire

        if(targets.Length > 0 && timer >= Attackcooldown) // checks if there are targets
        {
            float distanceToTarget = Vector2.Distance(targets[0].transform.position, transform.position); // check if target is in range

            if (distanceToTarget >= minrange && distanceToTarget <= maxrange)
            {
                pumpkin.Fire(transform); // fires pumpkin
                timer = 0f;// resets timer
            }
        }
    }

    private void LateUpdate() 
    {
        if (targets.Length > 0)
        {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed); // sets velocity
        Vector2 aimDirection = rb.position - (Vector2)targets[0].transform.position; //sets aim
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = aimAngle; // sets rotation
        }
    }
}