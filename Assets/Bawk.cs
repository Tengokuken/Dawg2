using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class Bawk : MonoBehaviour {

    // Use this for initialization
    public MovieTexture movie;
    private AudioSource audio;
    void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
    }
    	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && movie.isPlaying)
        {
            movie.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
    {
        movie.Play();
    }
}
}
