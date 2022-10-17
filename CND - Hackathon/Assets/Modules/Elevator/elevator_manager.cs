using elZach.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class elevator_manager : MonoBehaviour
{

    public Animatable elevatorExitDoor;
    
    public AudioSource elevatorSound;

    Coroutine startedRoutine;

    CinemachineImpulseSource impulse;

    private void Start()
    {
        impulse = transform.GetComponent<CinemachineImpulseSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (startedRoutine != null) return;
        if (other.CompareTag("Player"))
        {

            elevatorSound.Play();
            Shake();
            startedRoutine = StartCoroutine(WaitUntilDoorOpens());
          

        }
    }


    void Shake()
    {
        impulse.GenerateImpulse();
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           elevatorExitDoor.PlayAt(2);
        }
    }


    IEnumerator WaitUntilDoorOpens()
    {
        yield return new WaitForSeconds(elevatorSound.clip.length);
        elevatorExitDoor.PlayAt(1);
        startedRoutine = null;
    }

}
