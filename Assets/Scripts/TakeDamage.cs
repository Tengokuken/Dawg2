using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {
    public float health;

    // Use this for initialization
    void Start () {
        health = (10 + (ButtonClick.selectedDog._Floors * 15)); //Enemy health scales with floors cleared
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Hit!" + health);
        health -= ButtonClick.selectedDog._Strength;
        if (health <= 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
