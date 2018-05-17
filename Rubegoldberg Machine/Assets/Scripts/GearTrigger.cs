using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTrigger : MonoBehaviour {

    public GameObject Gear0;
    public GameObject Gear1;
    public GameObject Gear2;

    private void OnTriggerEnter(Collider other)
    {
        Gear0.GetComponent<GearSpin>().rotationTrigger = true;
        Gear1.GetComponent<GearSpin>().rotationTrigger = true;
        Gear2.GetComponent<GearSpin>().rotationTrigger = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
