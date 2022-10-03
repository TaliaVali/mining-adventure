using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndWait : MonoBehaviour
{

    public AudioSource sound;
    public int waitSeconds;


    IEnumerator Start()
    {
        while (true)
        {
            sound.Play();
            yield return new WaitForSeconds(sound.clip.length + waitSeconds);
        }
    }





}
