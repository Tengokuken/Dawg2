using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour {
    public Toggle mute;
    public static bool muted;
	// Use this for initialization
	void Start () {
        mute = GameObject.Find("Toggle").GetComponent<Toggle>();
        mute.onValueChanged.AddListener((value) =>
        {
            MuteSound(value);
        });
        if (muted)
        {
            mute.isOn = true;
            muted = false;
        }
        else
        {
            mute.isOn = false;
            muted = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void MuteSound(bool value)
    {
        if (value)
            AudioListener.pause = true;
        else
            AudioListener.pause = false;
    }
}
