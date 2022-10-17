using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject player;
    public Transform startPosition;


  
    void Update()
    {
        if (Input.GetKeyDown("r")) {

            //Debug.Log("´pressed r ");
            player.transform.position = startPosition.transform.position;

        }
    }
}
