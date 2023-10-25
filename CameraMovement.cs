using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] Camera cam;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
   
    float zoom;
    Vector2 moveDirection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] Camera cam;
    [SerializeField] Camera ortho;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
   
    float zoom = 10;
    Vector2 moveDirection;



    // Update is called once per frame
    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

       
        moveDirection = new Vector2(moveX, moveY).normalized;
        
        if((ortho.orthographicSize -Input.GetAxis("Mouse ScrollWheel") * zoom) <= 10)
        {

        }
        else
        {
            ortho.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoom;

        }

        if((cam.fieldOfView - Input.GetAxis("Mouse ScrollWheel") * zoom) <= 10)
        {

        }
        else
        {
            cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * zoom;
        }


    }

     private void FixedUpdate()
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
            
        }

     
      

}




    // Update is called once per frame
    void Update()
    {
        cam.orthographicSize += Input.GetAxis("Mouse ScrollWheel") * zoom;
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

       
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

     private void FixedUpdate()
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        
            
        }

     
      

}

