using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public Text dogeCoin;
    [SerializeField]
    public static int dogeCounter=0;
    public float moveSpeed;                 //This can change, based on the move speed of the class DogStats
    private CharacterController controller;
    public Transform mainCamMove;
    public static bool doggoDead;
    public Transform moveDoggo;
    public Vector2 moveVector;
    private float fillAmount;
    [SerializeField]
    private float health = 100f;
    [SerializeField]
    private float lerpSpeed;
    [SerializeField]
    private Image content;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //Deplete health
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        health -= 5;
    //        HandleBar();
    //    }
    //    //add more if statements here


    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        setCoinCounter();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = ButtonClick.selectedDog._MoveSpeed;
        moveVector = Vector2.zero;
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.y = Input.GetAxis("Vertical") * moveSpeed;
        controller.Move(moveVector * Time.deltaTime);
        HandleBar();
    }
    public float Value
    {
        set
        {
            fillAmount = Map(health);
        }
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
                dogeCounter++;
                setCoinCounter();
                Destroy(other.gameObject); //if you want object to die
            }
            //Test
            if (other.gameObject.name.StartsWith("SpeedUp"))
            {
                ButtonClick.selectedDog._MoveSpeed += 10;
                Destroy(other.gameObject); //if you want object to die
            }
            if (other.gameObject.name.StartsWith("Slime"))
            {
                health -= 5;
                HandleBar();
                Destroy(other.gameObject);
            }

            if (other.gameObject.name.StartsWith("ASUp"))
            {
                ButtonClick.selectedDog._AttackSpeed--;
                Destroy(other.gameObject); //if you want object to die
            }
            //Destroy(gameObject); //if you want to die
        }

        else if (other.gameObject.tag == "DeathTest" /* || doggo.health = 0*/)
        {
            Debug.Log("Collided!");
            doggoDead = true;
            Destroy(gameObject); //if you want to die
        }

        else if (other.gameObject.tag == "Exit")
        {
            Debug.Log("Exit");
            other.gameObject.SetActive(false);
            StartCoroutine(CountDown(other));
            if (moveVector.x > 0 && moveVector.x > Mathf.Abs(moveVector.y))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(78f, 0, 0);
            }

            else if (moveVector.x < 0 && moveVector.x < Mathf.Abs(moveVector.y))
            {
                mainCamMove.transform.position = mainCamMove.position + new Vector3(-78f, 0, 0);
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
        else if (other.gameObject.tag == "Stairs")
        {
            int nextScene;

            if (ButtonClick.selectedDog.NextFloor() == 5)
                SceneManager.LoadScene(14);
            else
            {
                System.Random rand = new System.Random();
                nextScene = rand.Next(8, 14);
                SceneManager.LoadScene(nextScene);
            }
        }
        else if (other.gameObject.tag == "money1")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }
        else if (other.gameObject.tag == "money2")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }
        else if (other.gameObject.tag == "money3")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }
        else if (other.gameObject.tag == "money4")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }
        else if (other.gameObject.tag == "money6")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }
        else if (other.gameObject.tag == "money6")
        {
            ButtonClick.itemPress = false;
            SceneManager.LoadScene(15);
        }

        else if (other.gameObject.tag == "wis1")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
        else if (other.gameObject.tag == "wis2")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
        else if (other.gameObject.tag == "wis3")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
        else if (other.gameObject.tag == "wis4")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
        else if (other.gameObject.tag == "wis5")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
        else if (other.gameObject.tag == "wis6")
        {
            ButtonClick.pressed = false;
            SceneManager.LoadScene(16);
        }
    }
    private float Map(float value)
    {
        return value / 100;
    }
    //changes bar's fill amount
    private void HandleBar()
    {
        lerpSpeed = 2;
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
    }
    IEnumerator CountDown(ControllerColliderHit other) //For exits
    {
        yield return new WaitForSeconds(0.4f);
        other.gameObject.SetActive(true);

    }
    void setCoinCounter()
    {
        dogeCoin.text = "$" + dogeCounter;
    }
}