using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public int time;
	// Use this for initialization
	void Start () {
		
	}

    void Update ()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, time);
    }
}
