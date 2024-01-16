using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] Camera Main;   // camera
    [SerializeField] private float moveSpeed = 5f;  // how fas it moves
    public Rigidbody2D rb;
   
    [SerializeField] private float zoom = 10;   // how much it zooms
    Vector2 moveDirection;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");   // gets the "WASD" keys to and makes them into a float value
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;   // makes the floats into a Vector2

            
        if((Main.orthographicSize -Input.GetAxis("Mouse ScrollWheel") * zoom) <= 10 || (Main.orthographicSize -Input.GetAxis("Mouse ScrollWheel") * zoom) >= 85 )   // if the camera isnt out of bounds you can move and zoom it
        {
        }
        else
        {
            Main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoom;    
        }
        
    }
    private void FixedUpdate()  // takes the input from the Vector2 and moves the camera
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}

