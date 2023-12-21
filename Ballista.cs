using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballista : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public BuildingProperties ballista;
    Vector2 moveDirection;
    Vector2 mousePosition;
    public float moveSpeed = 5f;
    public Arrow arrow;
    public GameObject[] targets;
    public float maxrange = 9f;
    [SerializeField] public float Attackcooldown = 5f;
    private float timer;

    private void Awake()
    {
        ballista.maxhealth = 6;
    }

    public void Update()
    {
        timer += Time.deltaTime;
        targets = GameObject.FindGameObjectsWithTag("Troop");

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if(targets.Length > 0 && timer >= Attackcooldown)
        {
            float distanceToTarget = Vector2.Distance(targets[0].transform.position, transform.position);

            if (distanceToTarget <= maxrange)
            {
                arrow.Fire();
                timer = 0f;
            }
        }
    }

    private void LateUpdate() 
    {
        if (targets.Length > 0)
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
            Vector2 aimDirection = rb.position - (Vector2)targets[0].transform.position;
            float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 90f;
            rb.rotation = aimAngle;
        }
    }
}
