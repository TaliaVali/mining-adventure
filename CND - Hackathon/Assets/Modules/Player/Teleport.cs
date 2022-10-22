using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject player;
    public Transform startPosition;

    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;
    public GameObject lamp4;
    public GameObject lamp5;


    void Update()
    {
        if (Input.GetKeyDown("r")) {

            //Debug.Log("´pressed r ");
            player.transform.position = startPosition.transform.position;


            lamp1.SetActive(false);
            lamp2.SetActive(false);
            lamp3.SetActive(false);
            lamp4.SetActive(false);
            lamp5.SetActive(false);

        }
    }
}
