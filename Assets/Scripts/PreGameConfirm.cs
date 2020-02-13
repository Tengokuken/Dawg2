using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreGameConfirm : MonoBehaviour{
    [SerializeField]
    private Animator controlDog; 
    public Text selectedLabel;
    public Text dogDescription;

    void Start()
    {
        selectedLabel = GameObject.Find("lblSelected").GetComponent<Text>();
        dogDescription = GameObject.Find("lblDescription").GetComponent<Text>();
        controlDog = this.GetComponent<Animator>();

        if (ButtonClick.selectedDog._Dog == "Doggo")
        {
            selectedLabel.text = "You have selected: Doggo";
            dogDescription.text = "Melee class dog. \nMelee attack. \nHigh base health and damage, low speed and attack speed.";
            RuntimeAnimatorController controlDog= (RuntimeAnimatorController)Resources.Load("Doge");
        }

        //Bork is selected
        else if (ButtonClick.selectedDog._Dog == "Bork")
        {
            selectedLabel.text = "You have selected: Bork";
            dogDescription.text = "Archer class dog. \nRanged attack. \nHigh base attack speed, low health and damage.";
        }

        //Pupper is selected
        else if (ButtonClick.selectedDog._Dog == "Pupper")
        {
            selectedLabel.text = "You have selected: Pupper";
            dogDescription.text = "Mage class dog. \nRanged attack. \n Low movement and attack speed, \n but gains an extra item slot.";
        }
    }
}
