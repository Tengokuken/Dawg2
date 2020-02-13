using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarPlayer : MonoBehaviour {
    [SerializeField]
    private HealthBarStat health;
    private void Awake()
    {
        health.Initialize();
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
