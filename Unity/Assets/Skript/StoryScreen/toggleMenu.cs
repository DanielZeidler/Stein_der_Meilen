using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleMenu : MonoBehaviour {

    public void toggleMenuView()
    {
        if (GameObject.Find("MenuPanel") != null)
        {
            if (GameObject.Find("toggleMenu").GetComponentInChildren<Text>().text == "hide menu")
            {
                GameObject.Find("toggleMenu").GetComponentInChildren<Text>().text = "SHOW MENU";

                GameObject.Find("MenuPanel").GetComponent<Image>().enabled = false;


                GameObject.Find("HelpButton").GetComponentInChildren<Text>().enabled = false;
                GameObject.Find("ContrButton").GetComponentInChildren<Text>().enabled = false;
                GameObject.Find("CreditsButton").GetComponentInChildren<Text>().enabled = false;
                GameObject.Find("HelpButton").GetComponentInChildren<Button>().enabled = false;
                GameObject.Find("ContrButton").GetComponentInChildren<Button>().enabled = false;
                GameObject.Find("CreditsButton").GetComponentInChildren<Button>().enabled = false;
                GameObject.Find("HelpButton").GetComponentInChildren<Image>().enabled = false;
                GameObject.Find("ContrButton").GetComponentInChildren<Image>().enabled = false;
                GameObject.Find("CreditsButton").GetComponentInChildren<Image>().enabled = false;

            }
            else if(GameObject.Find("toggleMenu").GetComponentInChildren<Text>().text == "SHOW MENU")
            {
                GameObject.Find("toggleMenu").GetComponentInChildren<Text>().text = "hide menu";

                GameObject.Find("MenuPanel").GetComponent<Image>().enabled = true;

                GameObject.Find("HelpButton").GetComponentInChildren<Text>().enabled = true;
                GameObject.Find("ContrButton").GetComponentInChildren<Text>().enabled = true;
                GameObject.Find("CreditsButton").GetComponentInChildren<Text>().enabled = true;
                GameObject.Find("HelpButton").GetComponentInChildren<Button>().enabled = true;
                GameObject.Find("ContrButton").GetComponentInChildren<Button>().enabled = true;
                GameObject.Find("CreditsButton").GetComponentInChildren<Button>().enabled = true;
                GameObject.Find("HelpButton").GetComponentInChildren<Image>().enabled = true;
                GameObject.Find("ContrButton").GetComponentInChildren<Image>().enabled = true;
                GameObject.Find("CreditsButton").GetComponentInChildren<Image>().enabled = true;
            }
        }
    }
}
