using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringCollision : MonoBehaviour {

    public GameObject bumper;

    private void OnCollisionEnter(Collision collision)
    {
        bumper.GetComponent<SpringBounce>().bounceTrigger = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
