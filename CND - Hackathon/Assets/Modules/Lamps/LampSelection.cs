using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSelection : MonoBehaviour
{

    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;
    public GameObject lamp4;
    public GameObject lamp5;



    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            lamp1.SetActive(true);
            lamp2.SetActive(false);
            lamp3.SetActive(false);
            lamp4.SetActive(false);
            lamp5.SetActive(false);
        }

        if (Input.GetKeyDown("2"))
        {
            lamp1.SetActive(false);
            lamp2.SetActive(true);
            lamp3.SetActive(false);
            lamp4.SetActive(false);
            lamp5.SetActive(false);
        }

        if (Input.GetKeyDown("3"))
        {
            lamp1.SetActive(false);
            lamp2.SetActive(false);
            lamp3.SetActive(true);
            lamp4.SetActive(false);
            lamp5.SetActive(false);
        }

        if (Input.GetKeyDown("4"))
        {
            lamp1.SetActive(false);
            lamp2.SetActive(false);
            lamp3.SetActive(false);
            lamp4.SetActive(true);
            lamp5.SetActive(false);
        }

        if (Input.GetKeyDown("5"))
        {
            lamp1.SetActive(false);
            lamp2.SetActive(false);
            lamp3.SetActive(false);
            lamp4.SetActive(false);
            lamp5.SetActive(true);
        }

    }







}
