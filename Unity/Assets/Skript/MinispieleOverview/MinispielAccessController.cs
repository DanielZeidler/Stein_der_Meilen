using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinispielAccessController : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        Button[] btnArray = new Button[11];
        Image[] imgArray = new Image[11];
        SpriteRenderer[] finishPicArray = new SpriteRenderer[11];

        for (int i = 1; i<12; i++)
        {
            btnArray[i-1] = GameObject.Find("Minispiel" + i + "Button").GetComponent<Button>();
            imgArray[i-1] = GameObject.Find("Minispiel" + i + "Image").GetComponent<Image>();
            finishPicArray[i - 1] = GameObject.Find("minispiel_abgeschlossen_" + i).GetComponent<SpriteRenderer>();

            btnArray[i - 1].interactable = false;
            imgArray[i - 1].enabled = false;

            finishPicArray[i - 1].enabled = false;
        }

        if (GameManager.Instance.accessMinispiel0)
        {
            btnArray[0].interactable = true;
            imgArray[0].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel1)
        {
            btnArray[1].interactable = true;
            imgArray[1].enabled = true;
            finishPicArray[0].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel2)
        {
            btnArray[2].interactable = true;
            imgArray[2].enabled = true;
            finishPicArray[1].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel3)
        {
            btnArray[3].interactable = true;
            imgArray[3].enabled = true;
            finishPicArray[2].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel4)
        {
            btnArray[4].interactable = true;
            imgArray[4].enabled = true;
            finishPicArray[3].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel5)
        {
            btnArray[5].interactable = true;
            imgArray[5].enabled = true;
            finishPicArray[4].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel6)
        {
            btnArray[6].interactable = true;
            imgArray[6].enabled = true;
            finishPicArray[5].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel7)
        {
            btnArray[7].interactable = true;
            imgArray[7].enabled = true;
            finishPicArray[6].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel8)
        {
            btnArray[8].interactable = true;
            imgArray[8].enabled = true;
            finishPicArray[7].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel9)
        {
            btnArray[9].interactable = true;
            imgArray[9].enabled = true;
            finishPicArray[8].enabled = true;
        }
        if (GameManager.Instance.accessMinispiel10)
        {
            btnArray[10].interactable = true;
            imgArray[10].enabled = true;
            finishPicArray[9].enabled = true;
        }


    }

}
