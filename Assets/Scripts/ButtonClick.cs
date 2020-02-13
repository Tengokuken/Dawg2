using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public static DogStats.Stats selectedDog = new DogStats.Stats();
    public int numItem;
    public Sprite[] btnImg;
    public Button butt;
    int count = 0;

    public void ClickToHelp()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToGame()
    {
        if (gameObject.tag == "money1")
        {
            SceneManager.LoadScene(8, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis1")
        {
            SceneManager.LoadScene(8, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "money2")
        {
            SceneManager.LoadScene(9, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis2")
        {
            SceneManager.LoadScene(9, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "money3")
        {
            SceneManager.LoadScene(10, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis3")
        {
            SceneManager.LoadScene(10, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "money4")
        {
            SceneManager.LoadScene(11, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis4")
        {
            SceneManager.LoadScene(11, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "money5")
        {
            SceneManager.LoadScene(12, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis5")
        {
            SceneManager.LoadScene(12, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "money6")
        {
            SceneManager.LoadScene(13, LoadSceneMode.Additive);
        }
        else if (gameObject.tag == "wis6")
        {
            SceneManager.LoadScene(13, LoadSceneMode.Additive);
        }
        else //else in case player is coming from nowhere
        {
            SceneManager.LoadScene(8, LoadSceneMode.Additive);
        }
    }

    public void ClickToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickToOptions()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowModes()
    {
        SceneManager.LoadScene(3);
    }

    public void ChooseCharacter()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "btnStory")
        {
            selectedDog._IsStoryMode = true;
            Debug.Log("Story Mode");
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "btnEndless")
        {
            selectedDog._IsStoryMode = false;
            Debug.Log("Endless Mode");
        }
        SceneManager.LoadScene(4);
    }

    public void CharacterStats()
    {
        selectedDog._Dog = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene(5);
    }

    public void GoToCutscenes()
    {
        SceneManager.LoadScene(8);
    }  

    public void GoToHighScore()
    {
        SceneManager.LoadScene(6);
    }

    public void WisdomDoge()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "AttackUp")
        {
            selectedDog._Strength++;
            //do whatever here
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "SpeedUp") 
        {
            selectedDog._MoveSpeed++;
        }
    }

    public static bool pressed = false;
    public void YesWisdom() //User selected "Yes" to Wisdom Dog's prompt! Gives wisdom.
    {
        var number = Random.Range(1, 6);
        if (pressed == true)
        {
            GameObject.FindWithTag("GreedyDog").GetComponent<Text>().text = "Do not abuse me.";
        }
        else if (pressed == false)
        {
            GameObject.FindWithTag("GreedyDog").GetComponent<Text>().text = "Bawk!";
            pressed = true;
            if (number == 1)
            {
                selectedDog._Strength++;
            }
            else if (number == 2)
            {
                selectedDog._Strength--;
            }
            else if (number == 3)
            {
                selectedDog._Range++;
            }
            else if (number == 4)
            {
                selectedDog._Range--;
            }
            else if (number == 5)
            {
                selectedDog._MoveSpeed++;
            }
            else if (number == 6)
            {
                selectedDog._MoveSpeed--;
            }
        }
        pressed = true;

    }

    public static int moneyItem;
    public static int RechargeBombCount = 0;
    public static bool itemPress = false;
    public void MoneyDogItem() //This generates items
    {
        var number = Random.Range(1, 10);
        if (PlayerMovement.dogeCounter < 10)
        {
            GameObject.FindWithTag("MoneyTxt").GetComponent<Text>().text = "Money Dog Says:\n'Insufficient funds!'\n'Collect more Dogecoin.'\n'Woof!'";
        }
        else if (PlayerMovement.dogeCounter >= 10)
        {
            if (itemPress == false)
            {
                var moneyItem = number;
                itemPress = true;
                GameObject.FindWithTag("MoneyTxt").GetComponent<Text>().text = "Thx.";
                PlayerMovement.dogeCounter -= 10;
            }
            else if (itemPress == true)
            {
                GameObject.FindWithTag("MoneyTxt").GetComponent<Text>().text = "Do not abuse me.";
            }
        }
       
    }
    
    public void ChangeImages()
    {
        butt = GameObject.Find("btnNextScene").GetComponent<Button>();
        btnImg = Resources.LoadAll<Sprite>("Cutscenes");
        if (count == 11)
            SceneManager.LoadScene(7); //Goes to game
        count++;
        butt.image.sprite = btnImg[count];
    }

    //public MovieTexture movie;
    //public AudioSource audio;
    //public void Bawk()
    //{
    //    //Renderer r = GetComponent<Renderer>();
    //    //MovieTexture movie = (MovieTexture)r.material.mainTexture;
    //    GetComponent<RawImage>().texture = movie as MovieTexture;
    //    audio = GetComponent<AudioSource>();
    //    if (movie.isPlaying)
    //    {
    //        movie.Pause();
    //    }
    //    else
    //    {
    //        movie.Play();
    //    }
    //    //((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    //}
}
