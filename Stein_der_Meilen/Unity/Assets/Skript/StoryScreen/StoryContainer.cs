using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StoryContainer : MonoBehaviour
{

    public string[] textbausteine;

    public static int accessStoryPart = 1;
    public static int actTextbaustein = 0;
    public static int actLetter;
    public static string actText = "";

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
 
}