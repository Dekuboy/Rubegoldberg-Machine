using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShaft : MonoBehaviour {

    public bool moveTrigger = false;
    private bool used = false;
    private int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moveTrigger && !used)
        {
            transform.Translate(0, 0, -0.02f);
            count++;
            if (count > 170)
            {
                used = true;
            }
        }
	}
}
