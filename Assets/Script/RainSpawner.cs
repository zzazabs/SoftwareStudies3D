using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour {

    public GameObject RainsPrefab;
    public int time;

	// Use this for initialization
	void FixedUpdate () {
        Instantiate(RainsPrefab, transform.position, Quaternion.identity);
	}

    //void DestroyObjectDelayed()
    //{
    //    // Kills the game object in 5 seconds after loading the object
    //    Destroy(gameObject, time);
    //}


}
