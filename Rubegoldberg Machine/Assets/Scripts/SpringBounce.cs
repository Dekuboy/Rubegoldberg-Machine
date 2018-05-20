using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBounce : MonoBehaviour
{

    public bool bounceTrigger = false;
    private bool used = false;
    public GameObject sphere;
    public GameObject pad;
    public GameObject spring;
    public int speed = 300;
    private float count = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bounceTrigger && !used)
        {
            float change = 0.08f * 60f * Time.deltaTime;
            float temp = spring.transform.position.y * spring.transform.localScale.y;
            spring.transform.localScale += new Vector3(0, change, 0);
            temp = (spring.transform.position.y * spring.transform.localScale.y - temp) / 4;
            spring.transform.Translate(0, -temp, 0);
            pad.transform.Translate(0, -temp, 0);
            count += change;
            if (count > 0.08f * 13)
            {
                sphere.GetComponent<Rigidbody>().velocity -= sphere.GetComponent<Rigidbody>().velocity;
                sphere.GetComponent<Rigidbody>().AddForce(pad.transform.TransformDirection(Vector3.up) * speed);
                used = true;
            }
        }
    }
}
