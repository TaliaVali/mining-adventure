using elZach.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class transform_elevator_door : MonoBehaviour
{

    public Animatable elevatorDoor;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            elevatorDoor.PlayAt(1);
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            elevatorDoor.PlayAt(2);
        }
    }




}
