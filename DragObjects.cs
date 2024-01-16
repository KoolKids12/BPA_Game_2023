using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
  private bool dragging = false;
  private bool open = false;
  private bool locked = false;
  private Vector3 offset;
  private Vector3 placement;

  [SerializeField] public Camera cam;

  void Start() {
    cam.enabled = true; // makes the can 

    locked = true; // makes it not draggable
  }

  void Update() {

    placement.x = transform.position.x;
    placement.y = transform.position.y;

    if (dragging && transform.position.y <= 40 && open == true) // checks if it is within bounds of ship
    {
      transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
    }
    else if(dragging && transform.position.y >= 40) // sets the new transformation to where it was dragged to
    {
      placement.y = 39;

      transform.position = placement; // sets placement
    }
    else
    {

    }

    if (dragging && transform.position.x <= 95 && open == true) // checks if it is within bounds of ship
    {
      transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + offset; // sets mouseposition to proper placement on screen

    }
    else if(dragging && transform.position.x >=95)
    {
      placement.x = 94;

      transform.position = placement; // sets dragged object to where it was dragged to

    }
    else{

    }
  }

  private void OnMouseDown() // gets offset from mousePosition
  {
    offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
    dragging = true;
  }

  private void OnMouseUp() // stops dragging
  {
    dragging = false;
  }

  private void OnMouseOver() // finds which object got clicked on
  {
    if(Input.GetMouseButtonDown(1))
    {
      if(locked == true)
      {
        locked = false;
      }
      if(locked == false)
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
      }
    }
  }
}