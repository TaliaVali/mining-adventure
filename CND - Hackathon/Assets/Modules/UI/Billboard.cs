using System.Collections;
using System.Collections.Generic;
using elZach.Common;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private static Camera _cam;
    private static Camera cam => _cam.OrSet(ref _cam, () => Camera.main);

    // public Vector3 localRotation;
    public bool ignoreY = true;
    
    // Update is called once per frame
    void LateUpdate()
    {
        var camEuler = cam.transform.eulerAngles;
        transform.rotation = Quaternion.Euler(ignoreY ? transform.eulerAngles.x : camEuler.x, camEuler.y, camEuler.z);
    }
}
