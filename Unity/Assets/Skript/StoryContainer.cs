using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryContainer : MonoBehaviour
{
    
    public string[] textbausteine;

    public static int actStoryPart = 0;
    public static int actTextbaustein = 0;
    public static int actLetter;
    private static string actText = "";

    public bool play = false;
    public bool pause = false;
    public float playSpeed;

    public static bool accessStoryPart_1 = true;
    public static bool accessStoryPart_2 = false;
    public static bool accessStoryPart_3 = false;
    public static bool accessStoryPart_4 = false;

    public bool rotationEarth = false;

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
    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.Find("StoryText") != null)
        {
            GameObject.Find("StoryText").GetComponent<Text>().text = actText.Substring(0, actLetter);
        }
        
    }

    public int getAccessStoryPart()
    {
        int part = 0;

        if (accessStoryPart_1) part = 3;
        if (accessStoryPart_2) part = 7;
        if (accessStoryPart_3) part = 13;
        if (accessStoryPart_4) part = 20;
        
        return part;
    }

    public void setText()
    {
        Text text = null;
        text = GameObject.Find("StoryText").GetComponent<Text>();
        text.text = "";
        if (text != null)
        {
            StartCoroutine(TextScroll(textbausteine[actTextbaustein]));
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
                actText = lineOfText;
                letter++;
                StoryContainer.actLetter = letter;
            }
            yield return new WaitForSeconds(playSpeed);
        }
        
        StoryContainer.Instance.play = false;
        GameObject.Find("StoryText").GetComponent<Text>().text = lineOfText;
        actLetter = lineOfText.Length;
        Canvas.ForceUpdateCanvases();
        GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
        Canvas.ForceUpdateCanvases();
    }
}