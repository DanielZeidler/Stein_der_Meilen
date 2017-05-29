using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnClickPlay : MonoBehaviour {

    public string[] paragraph;
    private int actPara = 0;
    // Use this for initialization
    private void Awake()
    {
        paragraph = new string[10];
    }
    void Start () {
        
    }

    private void OnMouseDown()
    {
        setText();
    }

    private void setText()
    {
        actPara = StoryContainer.actParagraph;
        paragraph = StoryContainer.Instance.paragraphen[actPara];
       
        Text text = GameObject.Find("StoryText").GetComponent<Text>();
        string paragraphString = "";
        foreach (string textbaustein in paragraph)
        {
            paragraphString += textbaustein;
        }
        text.text = paragraphString;
    }

    // Update is called once per frame
    void Update () {
        if(actPara != StoryContainer.actParagraph)
        {
            setText();
        }
        
        
	}
}
