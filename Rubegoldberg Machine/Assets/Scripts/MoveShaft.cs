using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShaft : MonoBehaviour {

    public bool moveTrigger = false;
    private bool used = false;
    private float count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moveTrigger && !used)
        {
            float change = -0.02f * 60f * Time.deltaTime;
            transform.Translate(0, 0, change);
            count -= change;
            if (count > 0.02 * 170)
            {
                used = true;
            }
        }
	}
}
