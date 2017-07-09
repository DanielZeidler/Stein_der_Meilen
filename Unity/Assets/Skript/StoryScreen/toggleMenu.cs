using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleMenu : MonoBehaviour {

    private Text[] toggleTexts = new Text[3];
    private Button[] toggleButtons = new Button[3];
    private Image[] toggleImages = new Image[3];

    private Image menuPanel;
    private Text toggleMenuText;

    private void Start()
    {
        menuPanel = GameObject.Find("MenuPanel").GetComponent<Image>();
        toggleMenuText = GameObject.Find("toggleMenu").GetComponentInChildren<Text>();

        toggleTexts[0] = GameObject.Find("HelpButton").GetComponentInChildren<Text>();
        toggleTexts[1] = GameObject.Find("ContrButton").GetComponentInChildren<Text>();
        toggleTexts[2] = GameObject.Find("CreditsButton").GetComponentInChildren<Text>();

        toggleButtons[0] = GameObject.Find("HelpButton").GetComponentInChildren<Button>();
        toggleButtons[1] = GameObject.Find("ContrButton").GetComponentInChildren<Button>();
        toggleButtons[2] = GameObject.Find("CreditsButton").GetComponentInChildren<Button>();

        toggleImages[0] = GameObject.Find("HelpButton").GetComponentInChildren<Image>();
        toggleImages[1] = GameObject.Find("ContrButton").GetComponentInChildren<Image>();
        toggleImages[2] = GameObject.Find("CreditsButton").GetComponentInChildren<Image>();
    }

    public void toggleMenuView()
    {
        if (menuPanel != null)
        {
            if (toggleMenuText.text == "schließe Menü")
            {
                toggleMenuText.text = "öffne Menü";
                menuPanel.enabled = false;
                setValue(false);
            }
            else if(toggleMenuText.text == "öffne Menü")
            {
                toggleMenuText.text = "schließe Menü";
                menuPanel.enabled = true;
                setValue(true);
            }
        }
    }

    private void setValue(bool value)
    {
        foreach (Button btn in toggleButtons) btn.enabled = value;
        foreach (Image img in toggleImages) img.enabled = value;
        foreach (Text txt in toggleTexts) txt.enabled = value;
    }
    
}
