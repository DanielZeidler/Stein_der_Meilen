using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * 
 * 
 * StoryContainer.accessStoryPart hier nur zum Test eingefügt; sollte nach abschluss der jeweiligen Minispiele ausgeführt werden;
 * 
 * 
 */

public class StoryScreenInteractionController : MonoBehaviour
{
    public string begruessung;

    public static bool start = true;

    public string[] infotexte;
    
    private Text infoBoxText;
    private Image InfoBoxImage;
    private GameObject itemPanel;

    private Dictionary<string, Button> btnMap;
    private Dictionary<string, MouseClickOnItem> erfindungenMap;

    public static Dictionary<string, Button> erfindungenButtonMap;
    public Button minispieleButton;
    
    private ParticleSystem.MainModule dustStorm;

    private static Text storyText;
    private static ScrollRect scrollRect;

    public AudioSource backgroundMusic;

    private bool oldPlay;
    private bool oldPause;
    private bool oldMute;

    private static StoryScreenInteractionController _instance;
    public static StoryScreenInteractionController Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            btnMap = new Dictionary<string, Button>();
            erfindungenMap = new Dictionary<string, MouseClickOnItem>();
            erfindungenButtonMap = new Dictionary<string, Button>();
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    // Use this for initialization
    void Start()
    {
        storyText = GameObject.Find("StoryText").GetComponent<Text>();
        scrollRect = GameObject.Find("ScrollRect").GetComponent<ScrollRect>();
        minispieleButton = GameObject.Find("MinispieleButton").GetComponent<Button>();
        backgroundMusic = GameObject.Find("ErdeWrapper").GetComponent<AudioSource>();

        backgroundMusic.Stop();
        if (start)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
            storyText.text = begruessung;
        }
        if (!StoryContainer.Instance.play && !StoryContainer.Instance.pause && !start)
        {
            StoryContainer.Instance.play = true;
            setText();
        }
        else if (StoryContainer.Instance.play && StoryContainer.Instance.pause)
        {
            StoryContainer.Instance.pause = false;
        }
        if (GameObject.Find("ScrollRect").GetComponent<ScrollRect>() != null && !start)
        {
            Canvas.ForceUpdateCanvases();
            GameObject.Find("ScrollRect").GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
            Canvas.ForceUpdateCanvases();
        }

        infoBoxText = GameObject.Find("InfoBoxText").GetComponent<Text>();
        InfoBoxImage = GameObject.Find("InfoBoxImage").GetComponent<Image>();
        itemPanel = GameObject.Find("ItemPanel");
        
        dustStorm = GameObject.Find("DustStorm").GetComponent<ParticleSystem>().main;

        btnMap.Add("2,2MiovChrButton", GameObject.Find("2,2MiovChrButton").GetComponent<Button>());
        btnMap.Add("500000vChrButton", GameObject.Find("500000vChrButton").GetComponent<Button>());
        btnMap.Add("4JtsdvChrButton", GameObject.Find("4JtsdvChrButton").GetComponent<Button>());
        btnMap.Add("3500vChrButton", GameObject.Find("3500vChrButton").GetComponent<Button>());
        btnMap.Add("1800vChrButton", GameObject.Find("1800vChrButton").GetComponent<Button>());
        btnMap.Add("1044Button", GameObject.Find("1044Button").GetComponent<Button>());
        btnMap.Add("1180Button", GameObject.Find("1180Button").GetComponent<Button>());
        btnMap.Add("1450Button", GameObject.Find("1450Button").GetComponent<Button>());
        btnMap.Add("1608Button", GameObject.Find("1608Button").GetComponent<Button>());
        btnMap.Add("1712Button", GameObject.Find("1712Button").GetComponent<Button>());
        btnMap.Add("1880Button", GameObject.Find("1880Button").GetComponent<Button>());

        erfindungenButtonMap.Add("WaffenButton", GameObject.Find("WaffenButton").GetComponent<Button>());
        erfindungenButtonMap.Add("FeuerButton", GameObject.Find("FeuerButton").GetComponent<Button>());
        erfindungenButtonMap.Add("RadButton", GameObject.Find("RadButton").GetComponent<Button>());
        erfindungenButtonMap.Add("SchriftButton", GameObject.Find("SchriftButton").GetComponent<Button>());
        erfindungenButtonMap.Add("GlasButton", GameObject.Find("GlasButton").GetComponent<Button>());
        erfindungenButtonMap.Add("SchiesspulverButton", GameObject.Find("SchiesspulverButton").GetComponent<Button>());
        erfindungenButtonMap.Add("WindmuehleButton", GameObject.Find("WindmuehleButton").GetComponent<Button>());
        erfindungenButtonMap.Add("BuchdruckButton", GameObject.Find("BuchdruckButton").GetComponent<Button>());
        erfindungenButtonMap.Add("FernrohrButton", GameObject.Find("FernrohrButton").GetComponent<Button>());
        erfindungenButtonMap.Add("DampfmaschineButton", GameObject.Find("DampfmaschineButton").GetComponent<Button>());
        erfindungenButtonMap.Add("GluebirneButton", GameObject.Find("GluebirneButton").GetComponent<Button>());

        erfindungenMap.Add("WaffenButton", GameObject.Find("WaffenButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("FeuerButton", GameObject.Find("FeuerButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("RadButton", GameObject.Find("RadButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("SchriftButton", GameObject.Find("SchriftButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("GlasButton", GameObject.Find("GlasButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("SchiesspulverButton", GameObject.Find("SchiesspulverButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("WindmuehleButton", GameObject.Find("WindmuehleButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("BuchdruckButton", GameObject.Find("BuchdruckButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("FernrohrButton", GameObject.Find("FernrohrButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("DampfmaschineButton", GameObject.Find("DampfmaschineButton").GetComponent<MouseClickOnItem>());
        erfindungenMap.Add("GluebirneButton", GameObject.Find("GluebirneButton").GetComponent<MouseClickOnItem>());
    }

    // Update is called once per frame
    void Update()
    {
        if (storyText != null && !start)
        {
            storyText.text = StoryContainer.actText.Substring(0, StoryContainer.actLetter);
        }

        if (StoryContainer.resetInfoBox)
        {
            infoBoxText.text = "";
            InfoBoxImage.enabled = false;
            StoryContainer.resetInfoBox = false;
            
        }

        //Enable FireButton
        if (StoryContainer.actTextbaustein == 1 && !StoryContainer.Instance.play && itemPanel != null && StoryContainer.interaction )
        {
            erfindungenButtonMap["WaffenButton"].interactable = true;
            if (!GameManager.Instance.accessMinispiel0)
            {
                infoBoxText.text = infotexte[0];
                InfoBoxImage.enabled = true;
                foreach(ParticleSystem partSys in GameObject.Find("StoryHintMarker").GetComponentsInChildren<ParticleSystem>())
                {
                    partSys.GetComponent<Renderer>().enabled = true;
                }

            }
            
            StoryContainer.interaction = false;
        }

        if (erfindungenMap["WaffenButton"].isClicked)
        {
            btnMap["2,2MiovChrButton"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                /*
                if (StoryContainer.accessStoryPart < 2)
                {
                    StoryContainer.accessStoryPart = 2;
                }
                */
                infoBoxText.text = infotexte[1];
                InfoBoxImage.enabled = true;
                foreach (ParticleSystem partSys in GameObject.Find("StoryHintMarker").GetComponentsInChildren<ParticleSystem>())
                {
                    partSys.GetComponent<Renderer>().enabled = false;
                }
                minispieleButton.onClick.AddListener(delegate
                {
                    infoBoxText.text = "";
                    InfoBoxImage.enabled = false;
                    foreach (Button btn in erfindungenButtonMap.Values) btn.interactable = true;
                });
            });
        }

        if(erfindungenMap["FeuerButton"].isClicked)
        {
            btnMap["500000vChrButton"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel1 = true;
            });
        }
        if (erfindungenMap["RadButton"].isClicked)
        {
            btnMap["4JtsdvChrButton"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel2 = true;
                if (StoryContainer.accessStoryPart < 5)
                {
                    StoryContainer.accessStoryPart = 5;
                }
            });
        }
        if (erfindungenMap["SchriftButton"].isClicked)
        {
            btnMap["3500vChrButton"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel3 = true;
                if (StoryContainer.accessStoryPart < 6)
                {
                    StoryContainer.accessStoryPart = 6;
                }
            });
        }
        if (erfindungenMap["GlasButton"].isClicked)
        {
            btnMap["1800vChrButton"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel4 = true;
                if (StoryContainer.accessStoryPart < 8)
                {
                    StoryContainer.accessStoryPart = 8;
                }
            });
        }
        if (erfindungenMap["SchiesspulverButton"].isClicked)
        {
            btnMap["1044Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel5 = true;
                if (StoryContainer.accessStoryPart < 9)
                {
                    StoryContainer.accessStoryPart = 9;
                }
            });
        }
        if (erfindungenMap["WindmuehleButton"].isClicked)
        {
            btnMap["1180Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel6 = true;
                if (StoryContainer.accessStoryPart < 10)
                {
                    StoryContainer.accessStoryPart = 10;
                }
            });
        }
        if (erfindungenMap["BuchdruckButton"].isClicked)
        {
            btnMap["1450Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel7 = true;
                if (StoryContainer.accessStoryPart < 14)
                {
                    StoryContainer.accessStoryPart = 14;
                }
            });
        }
        if (erfindungenMap["FernrohrButton"].isClicked)
        {
            btnMap["1608Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel8 = true;
                if (StoryContainer.accessStoryPart < 16)
                {
                    StoryContainer.accessStoryPart = 16;
                }
            });
        }
        if (erfindungenMap["DampfmaschineButton"].isClicked)
        {
            btnMap["1712Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel9 = true;
                if (StoryContainer.accessStoryPart < 17)
                {
                    StoryContainer.accessStoryPart = 17;
                }
            });
        }
        if (erfindungenMap["GluebirneButton"].isClicked)
        {
            btnMap["1880Button"].onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel10 = true;
                if (StoryContainer.accessStoryPart < 19)
                {
                    StoryContainer.accessStoryPart = 20;
                }
            });
        }


        if (StoryContainer.actTextbaustein < 1 && StoryContainer.actTextbaustein >= 0)
        {
            dustStorm.maxParticles = 110;
        }
        else if (StoryContainer.actTextbaustein < 2 && StoryContainer.actTextbaustein >= 1)
        {
            dustStorm.maxParticles = 110;
        }
        else if (StoryContainer.actTextbaustein < 4 && StoryContainer.actTextbaustein >= 2)
        {
            dustStorm.maxParticles = 100;
        }
        else if (StoryContainer.actTextbaustein < 5 && StoryContainer.actTextbaustein >= 4)
        {
            dustStorm.maxParticles = 90;
        }
        else if (StoryContainer.actTextbaustein < 6 && StoryContainer.actTextbaustein >= 5)
        {
            dustStorm.maxParticles = 80;
        }
        else if (StoryContainer.actTextbaustein < 7 && StoryContainer.actTextbaustein >= 6)
        {
            dustStorm.maxParticles = 70;
        }
        else if (StoryContainer.actTextbaustein < 9 && StoryContainer.actTextbaustein >= 7)
        {
            dustStorm.maxParticles = 60;
        }
        else if (StoryContainer.actTextbaustein < 10 && StoryContainer.actTextbaustein >= 9)
        {
            dustStorm.maxParticles = 50;
        }
        else if (StoryContainer.actTextbaustein < 14 && StoryContainer.actTextbaustein >= 10)
        {
            dustStorm.maxParticles = 40;
        }
        else if (StoryContainer.actTextbaustein < 15 && StoryContainer.actTextbaustein >= 14)
        {
            dustStorm.maxParticles = 30;
        }
        else if (StoryContainer.actTextbaustein < 18 && StoryContainer.actTextbaustein >= 15)
        {
            dustStorm.maxParticles = 20;
        }
        else if (StoryContainer.actTextbaustein < 20 && StoryContainer.actTextbaustein >= 18)
        {
            dustStorm.maxParticles = 10;
        }
        else
        {
            dustStorm.maxParticles = 0;
        }

        if(oldPlay != StoryContainer.Instance.play || oldPause != StoryContainer.Instance.pause || oldMute != StoryContainer.Instance.mute)
        {
            if (StoryContainer.Instance.play && !StoryContainer.Instance.pause)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.Play();
            }
            if (StoryContainer.Instance.play && StoryContainer.Instance.pause)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.Pause();
            }
            if (!StoryContainer.Instance.play && StoryContainer.Instance.pause)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.Pause();
            }
            if (!StoryContainer.Instance.play && !StoryContainer.Instance.pause)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.Stop();
            }
            if (StoryContainer.Instance.mute)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.mute = true;
            }
            if (!StoryContainer.Instance.mute)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.mute = false;
            }

            oldMute = StoryContainer.Instance.mute;
            oldPause = StoryContainer.Instance.pause;
            oldPlay = StoryContainer.Instance.play;
        }
    }
    
    public void setText()
    {
        storyText.text = "";
        if (storyText != null)
        {
            StartCoroutine(TextScroll(StoryContainer.Instance.textbausteine[StoryContainer.actTextbaustein]));
        }

    }

    private IEnumerator TextScroll(string lineOfText)
    {
        int letter = 0;

        while (letter < lineOfText.Length && StoryContainer.Instance.play)
        {
            if (!StoryContainer.Instance.pause)
            {
                Canvas.ForceUpdateCanvases();
                if (scrollRect != null)
                {
                    scrollRect.verticalNormalizedPosition = 0f;
                    Canvas.ForceUpdateCanvases();
                    storyText.text += lineOfText[letter];
                }
                StoryContainer.actText = lineOfText;
                letter++;
                StoryContainer.actLetter = letter;
            }
            yield return new WaitForSeconds(StoryContainer.Instance.playSpeed);
        }

        StoryContainer.Instance.play = false;

        if (scrollRect != null && storyText != null)
        {
            storyText.text = lineOfText;
            StoryContainer.actLetter = lineOfText.Length;
            Canvas.ForceUpdateCanvases();
            scrollRect.verticalNormalizedPosition = 0f;
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
