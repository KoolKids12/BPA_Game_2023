using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] Camera Main;
    [SerializeField] private float moveSpeed = 5f;
    public Rigidbody2D rb;
   
    float zoom = 10;
    Vector2 moveDirection;



    // Update is called once per frame
    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

       
        moveDirection = new Vector2(moveX, moveY).normalized;

        
        if((Main.orthographicSize -Input.GetAxis("Mouse ScrollWheel") * zoom) <= 10 || (Main.orthographicSize -Input.GetAxis("Mouse ScrollWheel") * zoom) >= 85 )
        {

        }
        else
        {
            Main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoom;

        }

    }

     private void FixedUpdate()
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
            
        }

     
      

}

