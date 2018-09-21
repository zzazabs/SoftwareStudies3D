using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{    
    public float jumpSpeed = 1.0f;
    void Start()
    {
        Debug.Log("Jump.Start() called!");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = jumpSpeed * Vector3.up;
        }
    }
}