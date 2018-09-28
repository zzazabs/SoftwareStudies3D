using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUsingMouse : MonoBehaviour
{

    // Use this for initialization

    //RotateMouse
    public float horizontalSpeed = 2.0F;
   public float verticalSpeed = 2.0F;

    // Use this for initialization
    void Update()
    // Rotate using Mouse
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        // transform.Rotate(0, 0, h);
        Debug.Log(h);
    }
}
