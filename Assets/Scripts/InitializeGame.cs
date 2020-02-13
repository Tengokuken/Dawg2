using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGame : MonoBehaviour {

    public static int[,] mapArray = new int[5, 4];
    public static int x;
    public static int y;
	void Start () {


        if (ButtonClick.selectedDog._Dog == "Doggo")
        {
            //use doggo sprite
        }

        else if (ButtonClick.selectedDog._Dog == "Bork")
        {
            //use pupper sprite and animations
        }

        else if (ButtonClick.selectedDog._Dog == "Pupper")
        {
            //use mango anmations
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
