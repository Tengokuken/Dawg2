using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMovement : MonoBehaviour
{
    private Rigidbody2D rigidDog;
    Animator animator;
    [SerializeField]
    public float speed;
    private bool faceR;
    // Use this for initialization
    void Start()
    {
        rigidDog = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public KeyCode MyKey;
    public string MyTrigger;

    void Update()
    {
        if (Input.GetKey(MyKey))
        {
            GetComponent<Animator>().SetTrigger(MyTrigger);
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        DoggoMove(x, y);
  




        //animator.SetFloat("Forward", x);
        //animator.SetFloat("Backward", s);
        //animator.SetFloat("Leftward", y);
        //animator.SetFloat("Rightward", d);
    }

    private void DoggoMove(float x, float y)
    {
        rigidDog.velocity = new Vector2(x * speed, y * speed);

    }
    private void changeAnimation()
    {
        
    }
}
