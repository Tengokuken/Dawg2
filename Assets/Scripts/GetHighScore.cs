using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHighScore : MonoBehaviour {

    public GUIText monstersSlain;
    public GUIText doggosSlain;
    public GUIText floorsCleared;
    public GUIText playerName;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < 10; i++) //shows top ten scores
        {
            monstersSlain.text += "\n" + PlayerPrefs.GetFloat("MonstersSlain");
            doggosSlain.text += "\n" + PlayerPrefs.GetFloat("DoggosSlain");
            floorsCleared.text += "\n" + PlayerPrefs.GetFloat("FloorsCleared");
            playerName.text += "\n" + PlayerPrefs.GetString("PlayerName");
        }
    }
}
