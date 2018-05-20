using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Camera rotateCam;
    public Camera boxCam0;
    public Camera boxCam1;
    public Camera boxCam2;

    public void SwitchCam(int _cam)
    {
        rotateCam.enabled = false;
        boxCam0.enabled = false;
        boxCam1.enabled = false;
        boxCam2.enabled = false;
        switch (_cam)
        {
            case 0:
                boxCam0.enabled = true;
                break;
            case 1:
                boxCam1.enabled = true;
                break;
            case 2:
                boxCam2.enabled = true;
                break;
            default:
                rotateCam.enabled = true;
                break;
        }
    }
}

