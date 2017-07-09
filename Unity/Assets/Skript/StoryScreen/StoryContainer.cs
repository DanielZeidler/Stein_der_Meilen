using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StoryContainer : MonoBehaviour
{
    public bool reset = false;
    public bool finish = false;
    public string[] textbausteine;

    public string begruessung;
    public static int accessStoryPart = 1;
    public static int actTextbaustein = 0;
    public static int actLetter;
    public static string actText = "Begrüßung BlaBlaBla";

    public bool play = false;
    public bool pause = false;
    public bool mute = false;

    public float playSpeed;

    public static bool interaction = false;
    public static bool resetInfoBox = false;
    
    public bool rotationEarth = false;


    private Text storyText;
    private ScrollRect scrollRect;

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

    private void Update()
    {
        if(actTextbaustein == 20)
        {
            finish = true;
        }
        if (reset)
        {
            accessStoryPart = 1;
            actTextbaustein = 0;
            actLetter = 0;
            actText = begruessung;

            play = false;
            pause = false;
            mute = false;
            

            interaction = false;
            resetInfoBox = false;

            rotationEarth = false;

            reset = false;
            finish = false;
        }

        if (GameManager.Instance.finishMinispiel0)
        {
            if (StoryContainer.accessStoryPart < 2)
            {
                StoryContainer.accessStoryPart = 2;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel1)
        {
            if (StoryContainer.accessStoryPart < 4)
            {
                StoryContainer.accessStoryPart = 4;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel2)
        {
            if (StoryContainer.accessStoryPart < 5)
            {
                StoryContainer.accessStoryPart = 5;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel3)
        {
            if (StoryContainer.accessStoryPart < 6)
            {
                StoryContainer.accessStoryPart = 6;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel4)
        {
            if (StoryContainer.accessStoryPart < 8)
            {
                StoryContainer.accessStoryPart = 8;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel5)
        {
            if (StoryContainer.accessStoryPart < 9)
            {
                StoryContainer.accessStoryPart = 9;

                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel6)
        {

            if (StoryContainer.accessStoryPart < 10)
            {
                StoryContainer.accessStoryPart = 10;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel7)
        {
            if (StoryContainer.accessStoryPart < 14)
            {
                StoryContainer.accessStoryPart = 14;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel8)
        {
            if (StoryContainer.accessStoryPart < 16)
            {
                StoryContainer.accessStoryPart = 16;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel9)
        {
            if (StoryContainer.accessStoryPart < 17)
            {
                StoryContainer.accessStoryPart = 17;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
        if (GameManager.Instance.finishMinispiel10)
        {
            if (StoryContainer.accessStoryPart < 18)
            {
                StoryContainer.accessStoryPart = 20;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
    }
}