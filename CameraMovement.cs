using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] Camera cam;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
   
    [SerializeField] float zoom = 10f;
    Vector2 moveDirection;



    // Update is called once per frame
    void Update()
    {
        if(cam.fieldOfView >=10 && cam.fieldOfView <= 155 )
        {
            cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * zoom;
        }
        else if(cam.fieldOfView < 10)
        {
             cam.fieldOfView = 10;
        }
        else if(cam.fieldOfView > 155)
        {
            cam.fieldOfView = 155;
        }
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

       
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

     private void FixedUpdate()
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
            
        }

     
      

}

