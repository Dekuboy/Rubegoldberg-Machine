using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTrigger : MonoBehaviour {

    public GameObject bumper;

    private void OnTriggerEnter(Collider other)
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
