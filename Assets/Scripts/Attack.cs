using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public static Vector2 direction;
    public GameObject bullet;
    public static GameObject projectile;
    public Camera camera;
    public float speed = 50.0f;
    public float attackTimer;
    public GUIText attackBar;

    // Use this for initialization
    void Start()
    {
        attackTimer = ButtonClick.selectedDog._AttackSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && attackTimer <= 0)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                projectile = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
                projectile.GetComponent<Rigidbody2D>().velocity = (hit.point - transform.position).normalized * speed;
                direction = projectile.GetComponent<Rigidbody2D>().velocity;
            }
            attackTimer = ButtonClick.selectedDog._AttackSpeed;
        }
        else
        {
            attackTimer-= Time.deltaTime;
            attackBar.text = attackTimer.ToString();

        }
    }
}
