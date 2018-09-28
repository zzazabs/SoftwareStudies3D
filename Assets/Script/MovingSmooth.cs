using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingSmooth : MonoBehaviour
{
    private Vector3 newposition;
    public float transitionSpeed = 2;

    // Use this for initialization 
    void Awake ()
    {
        newposition = transform.position;
 }
    void Update()
    {
        PositionChanging();
    }

    void PositionChanging ()
    {
        Vector3 positionA = new Vector3(15, 29, -24);
        Vector3 positionB = new Vector3(30, 29, -24);
        Vector3 positionC = new Vector3(45, 29, -24);
        Vector3 positionD = new Vector3(60, 29, -24);

        if (Input.GetKeyDown(KeyCode.Q))
            newposition = positionA;

        if (Input.GetKeyDown (KeyCode.W))
            newposition = positionB;

        if (Input.GetKeyDown (KeyCode.E))
            newposition = positionC;

        if (Input.GetKeyDown (KeyCode.R))
            newposition = positionD;

        transform.position = Vector3.Lerp(transform.position, newposition, Time.deltaTime * transitionSpeed);

    }

    void LateUpdate ()
    {
        //Rotation Position
        //Vector3 currentAngle = new Vector3 ( 
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed), 
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed), 
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        //transform.eulerAngles = currentAngle;
    }
}
