using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryContainer : MonoBehaviour
{
    
    public string[] textbausteine;
    public Dictionary<int, string[]> paragraphen;
    public static int actParagraph;
    public static int actTextbaustein;
    public bool play = false;
    public bool pause = false;
    private static string actText = "";
    public float playSpeed;
    private static StoryContainer _instance;

    public static StoryContainer Instance
    {
        get { return _instance; }
    }


    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            paragraphen = new Dictionary<int, string[]>();
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        if (paragraphen.Keys.Count == 0)
        {
            //map textbausteine to paragraphen
            string[] tmp = new string[4];
            for (int i = 0, n = 0; i <= 3; i++, n++)
            {
                tmp[n] = textbausteine[i];
            }

            paragraphen.Add(0, tmp);

            tmp = new string[4];
            for (int i = 4, n = 0; i <= 7; i++, n++)
            {
                tmp[n] = textbausteine[i];
            }
            paragraphen.Add(1, tmp);

            tmp = new string[6];
            for (int i = 8, n = 0; i <= 13; i++, n++)
            {
                tmp[n] = textbausteine[i];
            }
            paragraphen.Add(2, tmp);

            tmp = new string[7];
            for (int i = 14, n = 0; i <= 20; i++, n++)
            {
                tmp[n] = textbausteine[i];
            }
            paragraphen.Add(3, tmp);
        }
        else
        {
            if (!StoryContainer.Instance.play && !StoryContainer.Instance.pause)
            {
                StoryContainer.Instance.play = true;
                StoryContainer.Instance.setText();
            }
            else if (StoryContainer.Instance.play && StoryContainer.Instance.pause)
            {
                StoryContainer.Instance.pause = false;
            }
        }

    }
   
    public void setText()
    {
        Text text = null;
        text = GameObject.Find("StoryText").GetComponent<Text>();
        text.text = "";
        string paragraph = "";
        if (text != null)
        {
            foreach (string textbaustein in paragraphen[actParagraph])
            {
                paragraph += textbaustein + "\n";
                actText = paragraph;


            }
            StartCoroutine(TextScroll(paragraph));
        }
    }

    private IEnumerator TextScroll(string lineOfText)
    {
        int letter = 0;

        while(letter < lineOfText.Length && play)
        {
            if (!pause)
            {
                Canvas.ForceUpdateCanvases();
                GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
                Canvas.ForceUpdateCanvases();

                GameObject.Find("StoryText").GetComponent<Text>().text += lineOfText[letter];
                letter++;
                StoryContainer.actTextbaustein = letter;
            }
            yield return new WaitForSeconds(playSpeed);
        }
        
        StoryContainer.Instance.play = false;
        GameObject.Find("StoryText").GetComponent<Text>().text = lineOfText;
        actTextbaustein = lineOfText.Length;
        Canvas.ForceUpdateCanvases();
        GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
        Canvas.ForceUpdateCanvases();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("StoryText") != null) GameObject.Find("StoryText").GetComponent<Text>().text = actText.Substring(0, actTextbaustein);
    }
}