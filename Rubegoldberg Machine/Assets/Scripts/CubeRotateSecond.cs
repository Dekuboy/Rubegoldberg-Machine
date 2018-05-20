using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeRotateSecond : MonoBehaviour
{
    private bool isOn = false;
    private bool used = false;
    private float angle = 90;
    public GameObject box;
    private float count = 0;

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
            float change = 1 * 60f * Time.deltaTime;
            box.transform.Rotate(0, change, 0);
            angle -= change;
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
                count += 60 * Time.deltaTime;
                if (count > 300)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
        }
    }
}
