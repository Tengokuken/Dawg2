using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateOnkey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public KeyCode MyKeyUp;
    public KeyCode MyKeyUp2;
    public string MyTriggerUp;

    public KeyCode MyKeyLeft;
    public KeyCode MyKeyLeft2;
    public string MyTriggerLeft;

    public KeyCode MyKeyDown;
    public KeyCode MyKeyDown2;
    public string MyTriggerDown;

    public KeyCode MyKeyRight;
    public KeyCode MyKeyRight2;
    public string MyTriggerRight;

    void Update()
    {
        if (Input.GetKey(MyKeyUp) || Input.GetKey(MyKeyUp2))
        {
            GetComponent<Animator>().SetTrigger(MyTriggerUp);
        }

        if (Input.GetKey(MyKeyLeft) || Input.GetKey(MyKeyLeft2))
        {
            GetComponent<Animator>().SetTrigger(MyTriggerLeft);
        }

        if (Input.GetKey(MyKeyDown) || Input.GetKey(MyKeyDown2))
        {
            GetComponent<Animator>().SetTrigger(MyTriggerDown);
        }

        if (Input.GetKey(MyKeyRight) || Input.GetKey(MyKeyRight2))
        {
            GetComponent<Animator>().SetTrigger(MyTriggerRight);
        }
    }
  
} 