using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
  private bool dragging = false;
  private bool open = false;
  private bool locked = true;
  private Vector3 offset;
  private Vector3 placement;
  
  [SerializeField] Camera cam;

  void Start() {
    cam.enabled = true;

    placement = transform.position;
  }
 private void OnMouseOver() 
    {

    if (Input.GetMouseButtonDown(1)) 
    {
      if(locked == true)
      {
        locked = false;
      }
      else if(locked == false)
      {
        locked = true;
      }
      if(open == false)
      {
        open = true;
        Debug.Log("Moving Enabled");
      }
      else
      {
        open = false;
        Debug.Log("Moving disabled");

      }
    }
    
    }
  void Update() {

    if (locked == true)
    {
      transform.position = placement;
    }

    placement.x = transform.position.x;
    placement.y = transform.position.y;

    if (dragging && transform.position.y <= 40 && open == true) {
      transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
    }
    else if(dragging && transform.position.y >= 40)
    {
      placement.y = 39;

      transform.position = placement;
    }
    else
    {

    }

    if (dragging && transform.position.x <= 95 && open == true)
    {
      transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + offset;

    }
    else if(dragging && transform.position.x >=95)
    {
      placement.x = 94;

      transform.position = placement;

    }
    else{

    }
  }

  private void OnMouseDown() {
    offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);

    dragging = true;
  }

  private void OnMouseUp() {
    dragging = false;
  }


}
