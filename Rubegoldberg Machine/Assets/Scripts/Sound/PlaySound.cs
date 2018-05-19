using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource sound;

    void OnCollisionEnter(Collision collision)
    {
        if (CollisionSound.col)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
