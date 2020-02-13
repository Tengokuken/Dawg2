using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {
    public float projSpeed;
	// Use this for initialization
	void Start () {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(projSpeed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = Attack.direction;
    }

    // Update is called once per frame
    void Update () {


	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall" || other.tag == "Enemy" /*|| other.tag == "Player"*/)
        {
            Destroy(gameObject);

        }
            
    }
}
