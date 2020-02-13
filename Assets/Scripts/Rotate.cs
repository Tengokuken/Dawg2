using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float power = 1500f;
    public float moveSpeed = 25f;
    public float Distance = 2;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        mousePositionVector3 = Camera.main.ScreenToWorldPoint(mousePositionVector3);

        Vector3 targetdir = mousePositionVector3 - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetdir);
    }
    }
