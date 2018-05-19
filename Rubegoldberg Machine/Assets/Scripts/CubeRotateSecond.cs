using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeRotateSecond : MonoBehaviour
{
    private bool isOn = false;
    private bool used = false;
    private int angle = 90;
    public GameObject box;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (!used)
        {
            isOn = true;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            box.transform.Rotate(0, 1, 0);
            angle--;
            if (angle <= 0)
            {
                isOn = false;
                used = true;
            }
        }
        else
        {
            if(used)
            {
                count++;
                if (count > 300)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }
    }
}
