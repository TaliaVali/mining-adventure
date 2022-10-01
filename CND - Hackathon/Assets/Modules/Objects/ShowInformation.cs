using elZach.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInformation : MonoBehaviour
{

    public Animatable information;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            information.gameObject.SetActive(true);
        }



    }


    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            information.PlayAt(0);
        }



    }



}
