using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLoops : MonoBehaviour
{
    public int Density = 10;
    // Use this for initialization
    void Start()
    {
        GameObject prefab = Resources.Load("Sphere") as GameObject;
        //for (int i = 1; i <= numTower; i = i + 1)   // Normal
        for (int i = 1; i <= Density; i = i + 1)  // Random

        {
            // for (int a = 1; a <= numTower; a = a + 1)     // Normal
            for (int a = 1; a <= Density; a = a + 1) // Random

            {
                // for (int x = 1; x <= numTower; x = x + 1) // Normal
                for (int x = 1; x <= Density; x = x + 1)    // Random

                {
                    // Create the loop first, and end the loops with creating the game object. Game object creation action should be done in the end !
                    GameObject go = Instantiate(prefab) as GameObject;
                    go.transform.position = Random.insideUnitSphere * 5;
                    Debug.Log("Creating Sphere: " + x);
                }
            }
        }
    }
}
