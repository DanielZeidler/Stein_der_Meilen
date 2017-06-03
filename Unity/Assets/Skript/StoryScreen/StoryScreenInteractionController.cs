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
    public string[] infotexte;

    private ButtonsInteractable btnInter;

    private void Awake()
    {
        btnInter = GameObject.Find("ItemPanel").GetComponent<ButtonsInteractable>();
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (StoryContainer.resetInfoBox)
        {
            GameObject.Find("InfoBoxText").GetComponent<Text>().text = "";
            GameObject.Find("InfoBoxImage").GetComponent<Image>().enabled = false;
            StoryContainer.resetInfoBox = false;
        }

        //Enable FireButton
        if (StoryContainer.actTextbaustein == 1 && !StoryContainer.Instance.play && GameObject.Find("ItemPanel") != null && !StoryContainer.interaction )
        {
            btnInter.disableButtonsInteractableInGameobjectChildrens(GameObject.Find("ItemPanel"));
            btnInter.enableButton("WaffenButton");
            if (!GameManager.Instance.accessMinispiel0)
            {
                GameObject.Find("InfoBoxText").GetComponent<Text>().text = infotexte[0];
                GameObject.Find("InfoBoxImage").GetComponent<Image>().enabled = true;
            }
            
            StoryContainer.interaction = false;
        }

        if (GameObject.Find("WaffenButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("2,2MiovChrButton").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if(StoryContainer.accessStoryPart < 2) StoryContainer.accessStoryPart = 2;
                GameObject.Find("InfoBoxText").GetComponent<Text>().text = infotexte[1];
                GameObject.Find("InfoBoxImage").GetComponent<Image>().enabled = true;
                GameObject.Find("MinispieleButton").GetComponent<Button>().onClick.AddListener(delegate
                {
                    GameObject.Find("InfoBoxText").GetComponent<Text>().text = "";
                    GameObject.Find("InfoBoxImage").GetComponent<Image>().enabled = false;
                    btnInter.enableButtonsInteractableInGameobjectChildrens(GameObject.Find("ItemPanel"));
                });
            });
        }

        if (GameObject.Find("FeuerButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("500000vChrButton").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel1 = true;
                if (StoryContainer.accessStoryPart < 4) StoryContainer.accessStoryPart = 4;
            });
        }
        if (GameObject.Find("RadButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("4JtsdvChrButton").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 5) StoryContainer.accessStoryPart = 5;
            });
        }
        if (GameObject.Find("SchriftButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("3500vChrButton").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 6) StoryContainer.accessStoryPart = 6;
            });
        }
        if (GameObject.Find("GlasButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1800vChrButton").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 8) StoryContainer.accessStoryPart = 8;
            });
        }
        if (GameObject.Find("SchiesspulverButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1044Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 9) StoryContainer.accessStoryPart = 9;
            });
        }
        if (GameObject.Find("WindmuehleButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1180Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 10) StoryContainer.accessStoryPart = 10;
            });
        }
        if (GameObject.Find("BuchdruckButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1450Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 14) StoryContainer.accessStoryPart = 14;
            });
        }
        if (GameObject.Find("FernrohrButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1608Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 16) StoryContainer.accessStoryPart = 16;
            });
        }
        if (GameObject.Find("DampfmaschineButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1712Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 17) StoryContainer.accessStoryPart = 17;
            });
        }
        if (GameObject.Find("GluebirneButton").GetComponent<MouseClickOnItem>().isClicked)
        {
            GameObject.Find("1880Button").GetComponent<Button>().onClick.AddListener(delegate {
                GameManager.Instance.accessMinispiel0 = true;
                if (StoryContainer.accessStoryPart < 19) StoryContainer.accessStoryPart = 19;
            });
        }
    }
    
}
