﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public float rotationSpeed;


    private void OnMouseDrag()
    {
        float Y = Input.GetAxis("Mouse Y")*rotationSpeed;

        transform.Rotate(Vector3.right, Y);
        
        float X = Input.GetAxis("Mouse X")*rotationSpeed;
        transform.Rotate(Vector3.up, -X);
    }
}
