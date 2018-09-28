using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze1Bool : MonoBehaviour
{

    public Transform myTransform;
    public bool MazeBool;
    public GameObject CurrentMaze;
    public GameObject NextMaze;

    //Active and Deactive

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MazeBool = true;
            Maze();
        }

    }

    void Maze()
    {
        if (MazeBool)
        {
            CurrentMaze.SetActive(false);
            NextMaze.SetActive(true);
        }


    }
}


