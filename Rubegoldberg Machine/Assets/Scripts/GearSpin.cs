using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSpin : MonoBehaviour {

    public float rotationSpeed;
    public bool rotationTrigger = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rotationTrigger)
        {
            transform.Rotate(0, rotationSpeed * 60 * Time.deltaTime, 0);
        }
	}
}
