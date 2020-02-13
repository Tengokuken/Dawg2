using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    
    Texture2D fadeTexture;
    float fadeSpeed = 0.2f;
    int drawDepth = -1000;

    private float alpha = 0.0f;
    private float fadeDir = -1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerMovement.doggoDead)
            OnGUI();
	}

    void OnGUI()
    {

        alpha -= fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        Color thisAlpha = GUI.color;
        thisAlpha.a = alpha;
        GUI.color = thisAlpha;

        GUI.depth = drawDepth;

        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
    }
}
