using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPreGame: MonoBehaviour
{
    public Animator animator;
    public GameObject sprite;
    [SerializeField]
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    public bool animation_bool;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (ButtonClick.selectedDog._Dog == "Doggo")
        {
            animator.Play("DogeFwd");
        }

        else if (ButtonClick.selectedDog._Dog == "Bork")
            animator.Play("GabeFwd");

        else if (ButtonClick.selectedDog._Dog == "Pupper")
        {
            animator.Play("MangoFwd");
        }
    }
}
