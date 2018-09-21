using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    public int numTower = 10;
    // Use this for initialization
    void Start()
    {
        GameObject prefab = Resources.Load("Tower Sphere") as GameObject;
        for (int i = 1; i <= numTower; i = i + 1)   // Normal
        //for (int i = Random.Range(1.15); i <= numTower; i = i + 1)  // Random
        
        {  
             for (int a = 1; a <= numTower; a = a + 1)     // Normal
            //for (int a = Random.Range(1.15); a <= numTower; a = a + 1) // Random
            
            {  
                 for (int x = 1; x <= numTower; x = x + 1) // Normal
                //for (int x = Random.Range(1.15); x <= numTower; x = x + 1)    // Random
                
                {
                    // Create the loop first, and end the loops with creating the game object. Game object creation action should be done in the end !
                    GameObject go = Instantiate(prefab) as GameObject;
                    go.transform.position = new Vector3(a+1, i+1, x + 1);
                    Debug.Log("Creating Tower: " + x);
                }
            }
        }    
    }
}
