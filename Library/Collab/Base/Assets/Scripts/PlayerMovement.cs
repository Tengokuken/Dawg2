using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;                 //This can change, based on the move speed of the class DogStats
    private CharacterController controller;
    public Transform mainCamMove;
    public static bool doggoDead;
    public Transform moveDoggo;
    public Vector2 moveVector;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = ButtonClick.selectedDog._MoveSpeed;
        moveVector = Vector2.zero;
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.y = Input.GetAxis("Vertical") * moveSpeed;
        controller.Move(moveVector * Time.deltaTime);
            
    }

    void OnControllerColliderHit(ControllerColliderHit other)
    {
        Debug.Log("Collided!");
        if (other.gameObject.tag == "Pick Up")
        {
            if (other.gameObject.name.StartsWith("DogeCoin"))
            {
                ButtonClick.selectedDog.IncreaseCoinCount();
                Debug.Log("DogeCoins: " + ButtonClick.selectedDog._DogeCoin);
                Destroy(other.gameObject); //if you want object to die
            }
            //Test
            if (other.gameObject.name.StartsWith("SpeedUp"))
            {
                ButtonClick.selectedDog._MoveSpeed += 10;
                Destroy(other.gameObject); //if you want object to die
            }

            if (other.gameObject.name.StartsWith("ASUp"))
            {
                ButtonClick.selectedDog._AttackSpeed--;
                Destroy(other.gameObject); //if you want object to die
            }
            //Destroy(gameObject); //if you want to die
        }

        else if (other.gameObject.tag == "Bullet")
        {

        }

        else if (other.gameObject.tag == "DeathTest" /* || doggo.health = 0*/)
        {
            Debug.Log("Collided!");
            doggoDead = true;
            Destroy(gameObject); //if you want to die
        }

        else if (other.gameObject.tag == "Exit")
        {
            bool isMove = false;
            Debug.Log("Exit");
            other.gameObject.SetActive(false);
            StartCoroutine(CountDown(other));
            if (moveVector.x > 0 && moveVector.x > Mathf.Abs(moveVector.y))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(78, 0, 0);
            }

            else if (moveVector.x < 0 && moveVector.x < Mathf.Abs(moveVector.y))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(-78, 0, 0);
            }

            else if (moveVector.y < 0 && moveVector.y < Mathf.Abs(moveVector.x))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(0, -33.2f, 0);
            }

            else if (moveVector.y > 0 && moveVector.y > Mathf.Abs(moveVector.x))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(0, 33.2f, 0);
            }


        }
        //add more if statements here
    }

    IEnumerator CountDown(ControllerColliderHit other)
    {
        yield return new WaitForSeconds(1);
        other.gameObject.SetActive(true);

    }
}