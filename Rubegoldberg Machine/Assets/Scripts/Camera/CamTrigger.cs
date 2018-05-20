using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour {

    public GameObject camList;
    public int change;
    private void OnTriggerEnter(Collider other)
    {
        camList.GetComponent<ChangeCam>().SwitchCam(change);
    }
}
