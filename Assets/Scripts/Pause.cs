using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private bool pressed = false;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && pressed == false)
        {
            Time.timeScale = 0;
            pressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pressed == true)
        {
            Time.timeScale = 1;
            pressed = false;
        }
    }
}
