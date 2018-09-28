using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Transform myTransform;

    //Active and Deactive
    public GameObject MazeActive;
    public GameObject MazeDeactive;
    public GameObject PlaneActive;
    public GameObject PlaneDeactive;
    public AudioClip alarm;

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //collision.gameObject.transform.position = new Vector3(4, -2, -1);
            collision.gameObject.transform.position = myTransform.position;
            Debug.Log("Touch", gameObject);

            //Active and Deactive
            MazeActive.SetActive(true);
            MazeDeactive.SetActive(false);

            PlaneActive.SetActive(true);
            PlaneDeactive.SetActive(false);
        }
    }

}
