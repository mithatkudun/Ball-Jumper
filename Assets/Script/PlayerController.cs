
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Touch touch;
    public float power = 15f;
    public float maxDrag = 5f;
    public LineRenderer lr;
    public Rigidbody rb;
    Vector3 dragStartPos;

  private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            DragStart();
        }
        if (Input.GetMouseButton(0))
        {
            Dragging();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DragRelease();
        }

    }

    void DragStart()
    {
        dragStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y + 7.3f, 15));
        dragStartPos.z = -5f;

        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPos);
    }
    void Dragging()
    {
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y + 7.3f, 15));
        draggingPos.z = -5f;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPos);
    }
    void DragRelease()
    {
        lr.positionCount = 0;
        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y + 7.3f, 15));
        dragReleasePos.z = -5f;

        Vector3 force = dragStartPos - dragReleasePos;
        Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        rb.AddForce(clampedForce, ForceMode.Impulse);
    }
   
    

}
