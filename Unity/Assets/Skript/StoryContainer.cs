using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryContainer : MonoBehaviour
{

    public string[] textbausteine;

    public static int accessStoryPart = 1;
    public static int actTextbaustein = 0;
    public static int actLetter;
    private static string actText = "";

    public bool play = false;
    public bool pause = false;
    public float playSpeed;

    public static bool interaction = false;
    public static bool resetInfoBox = false;
    
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

        while (letter < lineOfText.Length && play)
        {
            if (!pause)
            {
                Canvas.ForceUpdateCanvases();
                if(GameObject.Find("ScrollRect") != null)
                {
                    GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
                    Canvas.ForceUpdateCanvases();
                    GameObject.Find("StoryText").GetComponent<Text>().text += lineOfText[letter];
                }
                actText = lineOfText;
                letter++;
                StoryContainer.actLetter = letter;
            }
            yield return new WaitForSeconds(playSpeed);
        }

        StoryContainer.Instance.play = false;
        
        if (GameObject.Find("ScrollRect") != null && GameObject.Find("StoryText") != null)
        {
            GameObject.Find("StoryText").GetComponent<Text>().text = lineOfText;
            actLetter = lineOfText.Length;
            Canvas.ForceUpdateCanvases();
            GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
            Canvas.ForceUpdateCanvases();
        }

        checkInteraction();
    }

    private void checkInteraction()
    {
        if (StoryContainer.actTextbaustein == 1)
        {
            StoryContainer.interaction = true;
        }
    }
}