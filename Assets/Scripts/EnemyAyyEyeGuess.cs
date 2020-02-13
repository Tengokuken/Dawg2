using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAyyEyeGuess : MonoBehaviour
{
    public Transform target;
    public static float speed;
    private float minDistance = 10f;
    private float range;
    public Camera cam;

    void Update()
    {
        speed = 5;
        range = Vector2.Distance(transform.position, target.position);

        //if (range < minDistance)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //}

        RaycastHit hit;

        Vector3 forward = (target.position - transform.position) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);

            Debug.DrawRay(transform.position, forward * 19, Color.red);
        }

            if (hit.transform.gameObject.tag == "PlayerHitBox")
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
