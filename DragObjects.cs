using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
  private bool dragging = false;
  private Vector3 offset;
  private Vector3 placement;

  [SerializeField] Camera cam;

  void Start() {
    cam.enabled = true;
  }

  void Update() {

    placement.x = transform.position.x;
    placement.y = transform.position.y;

    if (dragging && transform.position.y <= 40 ) {
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

    if (dragging && transform.position.x <= 95)
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
