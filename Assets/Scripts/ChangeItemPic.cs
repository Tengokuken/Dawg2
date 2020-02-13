using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeItemPic : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (ButtonClick.moneyItem == 1)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("B3");
        }
        else if (ButtonClick.moneyItem == 2)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("B2");
        }
        else if (ButtonClick.moneyItem == 3)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("B1");
        }
        else if (ButtonClick.moneyItem == 4)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("decoydog");
        }
        else if (ButtonClick.moneyItem == 5)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("fan");
        }
        else if (ButtonClick.moneyItem == 6) // Doggo biscuit; +500 health. one-time
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("woofo");
        }
        else if (ButtonClick.moneyItem == 7) // 50/50 Candy; +50 health. 50 second timer
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("candy");
        }
        // Flashlight
        else if (ButtonClick.moneyItem == 8) // Stuns all enemies for 3 seconds
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("flashlight");
        }
        else if (ButtonClick.moneyItem == 9)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("super");
        }
        else if (ButtonClick.moneyItem == 10)
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("lazers");
        }
        else if ((ButtonClick.moneyItem == 0))
        {
            GameObject.FindWithTag("itmTag").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("blank");
        }
    }
}
