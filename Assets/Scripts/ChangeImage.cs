using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {
    //private Button butt;
    //public int count = 0;
    //public void Change() // this changes the cut scenes at the intro
    //{
    //    butt = GetComponent<Button>();
    //    count++;
    //    Sprite[] images = Resources.LoadAll<Sprite>("Cutscenes");
    //    if (count == images.Length)
    //    {
    //        butt.image.sprite = images[count];
    //    }
    //}
    public Sprite[] btnImg;
    public Button butt;
    int count = 0;

    void LoadSprites()
    {
        btnImg = Resources.LoadAll<Sprite>("Cutscenes");
    }
    public void On_Click_Button()
    {
        count++;
        if (count == btnImg.Length)
        {
            butt.image.sprite = btnImg[count];
        }
        
    }
}
