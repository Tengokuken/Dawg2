using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemUse : MonoBehaviour {

    public static float speed;
    private float timer = 0;
    private float maxTime = 2;
    // Use this for initialization
    void Start () {
        speed = 5;
	}

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ItemCall();
        }
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            speed = 5;
        }
    }

    void ItemCall ()
    {
        if (ButtonClick.moneyItem == 1)
        {
            // how the heck do i change the image dammit 
            GameObject.FindWithTag("itmslot").GetComponent<image>().image = "Money Dog Says:\n'Insufficient funds!'\n'Collect more Dogecoin.'\n'Woof!'";
        }
        else if (ButtonClick.moneyItem == 2)
        {
            
        }
        else if (ButtonClick.moneyItem == 3)
        {

        }
        else if (ButtonClick.moneyItem == 4)
        {

        }
        else if (ButtonClick.moneyItem == 5)
        {

        }
        else if (ButtonClick.moneyItem == 6) // Doggo biscuit; +500 health. one-time
        {
            ButtonClick.selectedDog._Health += 500;
            ButtonClick.moneyItem = 0;
        }
        else if (ButtonClick.moneyItem == 7) // 50/50 Candy; +50 health. 50 second timer
        {
            ButtonClick.selectedDog._Health += 10;
            ButtonClick.moneyItem = 0;
        }
        // Flashlight
        else if (ButtonClick.moneyItem == 8) // Stuns all enemies for 3 seconds
        {
            speed = 0;
            timer = 0;
        }
        else if (ButtonClick.moneyItem == 9)
        {

        }
        else if (ButtonClick.moneyItem == 10)
        {

        }
    }
}
