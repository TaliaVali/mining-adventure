using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {

            Application.Quit();
        }
    }


   
    



}
