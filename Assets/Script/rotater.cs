using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour
{

    public Vector3 RotatePointAroundPivot ( Vector3 point,  Vector3 pivot, Vector3 angles)
    {
        return Quaternion.Euler(angles) * (point - pivot) + pivot;
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 0f));
    }
}
