using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLauncher : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    
    Vector2 moveDirection;
    Vector2 mousePosition;
    public float moveSpeed = 5f;
    public Pumpkin pumpkin;
    public GameObject[] targets;
    public float minrange = 2f;
    public float maxrange = 12f;

    public void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Troop");

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if(targets.Length > 0)
        {
            Debug.Log("Found target");
            float distanceToTarget = Vector2.Distance(targets[0].transform.position, transform.position);

            if (distanceToTarget >= minrange && distanceToTarget <= maxrange)
            {
                Debug.Log("In range");
                pumpkin.Fire();
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 aimDirection = rb.position - (Vector2)targets[0].transform.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}