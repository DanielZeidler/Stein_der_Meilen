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
    public AudioSource voiceText;
    private AudioController aC;

    private bool oldPlay;
    private bool oldPause;
    private bool oldMute;

    private Animator animator;
    private bool feedBack = false;
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
            animator = GameObject.Find("FeedbackContainer").GetComponent<Animator>();
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
        voiceText = GameObject.Find("StoryPanel").GetComponent<AudioSource>();
        aC = GameObject.Find("AudioWrapper").GetComponent<AudioController>();

        
        if (start)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
            storyText.text = begruessung;
            backgroundMusic.Stop();
        }
        else
        {
            backgroundMusic.Play();
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
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["2,2MiovChrButton"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel0 = true;
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
                            foreach (Button bton in erfindungenButtonMap.Values) bton.interactable = true;
                        });
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }

        if(erfindungenMap["FeuerButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["500000vChrButton"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel1 = true;
                    });
                }else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["RadButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["4JtsdvChrButton"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel2 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["SchriftButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["3500vChrButton"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel3 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["GlasButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1800vChrButton"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel4 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["SchiesspulverButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1044Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel5 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["WindmuehleButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1180Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel6 = true;
                        if (StoryContainer.accessStoryPart < 10)
                        {
                            StoryContainer.accessStoryPart = 10;
                        }
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["BuchdruckButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1450Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel7 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["FernrohrButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1608Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel8 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["DampfmaschineButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1712Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel9 = true;
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
        }
        if (erfindungenMap["GluebirneButton"].isClicked)
        {
            foreach (Button btn in btnMap.Values)
            {
                btn.onClick.RemoveAllListeners();
                if (btn == btnMap["1880Button"])
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(true);
                        GameManager.Instance.accessMinispiel10 = true;
                        if (StoryContainer.accessStoryPart < 19)
                        {
                            StoryContainer.accessStoryPart = 20;
                        }
                    });
                }
                else
                {
                    btn.onClick.AddListener(delegate {
                        startFeedback(false);
                    });
                }
            }
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
              //  StoryScreenInteractionController.Instance.backgroundMusic.Play();
                StoryScreenInteractionController.Instance.voiceText.Play();
            }
            if (StoryContainer.Instance.play && StoryContainer.Instance.pause)
            {
              //  StoryScreenInteractionController.Instance.backgroundMusic.Pause();
                StoryScreenInteractionController.Instance.voiceText.Pause();
            }
            if (!StoryContainer.Instance.play && StoryContainer.Instance.pause)
            {
              //  StoryScreenInteractionController.Instance.backgroundMusic.Pause();
                StoryScreenInteractionController.Instance.voiceText.Pause();
            }
            if (!StoryContainer.Instance.play && !StoryContainer.Instance.pause)
            {
              //  StoryScreenInteractionController.Instance.backgroundMusic.Stop();
                StoryScreenInteractionController.Instance.voiceText.Stop();
            }
            if (StoryContainer.Instance.mute)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.mute = true;
                StoryScreenInteractionController.Instance.voiceText.mute = true;
            }
            if (!StoryContainer.Instance.mute)
            {
                StoryScreenInteractionController.Instance.backgroundMusic.mute = false;
                StoryScreenInteractionController.Instance.voiceText.mute = false;
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
        switch (StoryContainer.actTextbaustein)
        {
            case 1: voiceText.clip = aC.leonardo_1; break;
            case 2: voiceText.clip = aC.leonardo_2; break;
            case 3: voiceText.clip = aC.leonardo_3; break;
            case 4: voiceText.clip = aC.leonardo_4; break;
            case 5: voiceText.clip = aC.leonardo_5; break;
            case 6: voiceText.clip = aC.leonardo_6; break;
            case 7: voiceText.clip = aC.leonardo_7; break;
            case 8: voiceText.clip = aC.leonardo_8; break;
            case 9: voiceText.clip = aC.leonardo_9; break;
            case 10: voiceText.clip = aC.leonardo_10; break;
            case 11: voiceText.clip = aC.leonardo_11; break;

            case 13: voiceText.clip = aC.leonardo_12; break;
            case 14: voiceText.clip = aC.leonardo_13; break;
            case 15: voiceText.clip = aC.lipperhey_1; break;
            case 16: voiceText.clip = aC.leonardo_14; break;
            case 17: voiceText.clip = aC.leonardo_15; break;
            case 18: voiceText.clip = aC.leonardo_16; break;
            case 19: voiceText.clip = aC.edison_1; break;
            case 20: voiceText.clip = aC.leonardo_17; break;
            default: voiceText.clip = null;break;
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

        //StoryContainer.Instance.play = false;

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

    private void startFeedback(bool boolean)
    {
        if (!feedBack)
        {
            if (boolean)
            {
                StartCoroutine(showFeedback("right"));
            }
            else StartCoroutine(showFeedback("wrong"));
            feedBack = true;
        }
    }

    private IEnumerator showFeedback(string name)
    {
        animator.SetBool(name, true);
        yield return new WaitForSeconds(1f);
        animator.SetBool(name, false);
        feedBack = false;
    }
}
