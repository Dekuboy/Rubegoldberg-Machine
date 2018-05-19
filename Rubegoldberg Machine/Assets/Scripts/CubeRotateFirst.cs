using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateFirst : MonoBehaviour
{

    private bool isOn = false;
    private bool used = false;
    private int angle = 90;
    public GameObject box;
    public GameObject container;
    public GameObject bumper;
    private int count = 0;
    public GameObject sphere;

    private void OnTriggerEnter(Collider other)
    {
        if (!used)
        {
            container.transform.Translate(-0.6f, 0, 0);
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
            box.transform.Rotate(0, 0, -1);
            angle--;
            if (angle <= 0)
            {
                isOn = false;
                used = true;
                container.transform.Translate(0.6f, 0, 0);
                sphere.GetComponent<Rigidbody>().velocity -= sphere.GetComponent<Rigidbody>().velocity;
            }
        }
        else
        {
            if (used)
            {
                if (count == 3)
                {
                    Vector3 temp = new Vector3(1, 0, 0);
                    sphere.GetComponent<Rigidbody>().velocity = temp;
                }
                if (count < 30)
                {
                    count++;
                }
                else
                {
                    if (count == 30)
                    {
                        bumper.GetComponent<SpringBounce>().bounceTrigger = true;
                        count = 50;
                    }
                }
            }
        }
    }
}
