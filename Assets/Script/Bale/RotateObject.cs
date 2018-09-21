using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour
{
    public float turnSpeed = 20f;

    // Use this for initialization
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        if (Input.GetKey(KeyCode.A))
              transform.Rotate (Vector3.back, turnSpeed * Time.deltaTime);
           // transform.RotateAround(Vector3.zero, Vector3.back, turnSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    
        
    }
}
