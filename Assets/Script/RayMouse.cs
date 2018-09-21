using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayMouse : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject prefab = Resources.Load("Sphere") as GameObject;
        if (Input.GetMouseButton(0))
        {
            GameObject go = Instantiate(prefab) as GameObject;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
        
    }
}
