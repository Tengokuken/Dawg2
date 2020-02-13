using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemUse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private float num = 0;
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ItemCall();
        }
    }

    void ItemCall ()
    {
        if (ButtonClick.moneyItem == 1)
        {
            Time.timeScale = 0;
        }
        else if (ButtonClick.moneyItem == 2)
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
        else if (ButtonClick.moneyItem == 0) // Stuns all enemies for 5 seconds
        {
            num = EnemyAyyEyeGuess.speed;
            for (int i = 0; i < Time.deltaTime * 5; i++)
            {
                EnemyAyyEyeGuess.speed = 0;
            }
            EnemyAyyEyeGuess.speed = num;
            ButtonClick.moneyItem = 0;
        }

    }
}
