using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timelineMarkerController : MonoBehaviour {

    private RectTransform timelineMarkerFlare;
    private Dictionary<string, Button> btnMap;

    private void Awake()
    {
        btnMap = new Dictionary<string, Button>();
    }

    void Start()
    {
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
        timelineMarkerFlare = GameObject.Find("TimelineMarkerFlare").GetComponent<RectTransform>();
    }
    
    // Use this for initialization
    void Update () {
        
        if (StoryContainer.actTextbaustein < 1 && StoryContainer.actTextbaustein >= 0)
        {
            timelineMarkerFlare.anchorMin = new Vector2(0, 0);
            timelineMarkerFlare.anchorMax = new Vector2(0, 0);
        }
        else if (StoryContainer.actTextbaustein < 2 && StoryContainer.actTextbaustein >= 1)
        {
            Vector2 value = calcMiddleOfRect(btnMap["2,2MiovChrButton"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 4 && StoryContainer.actTextbaustein >= 2)
        {
            Vector2 value = calcMiddleOfRect(btnMap["500000vChrButton"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 5 && StoryContainer.actTextbaustein >= 4)
        {
            Vector2 value = calcMiddleOfRect(btnMap["4JtsdvChrButton"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 6 && StoryContainer.actTextbaustein >= 5)
        {
            Vector2 value = calcMiddleOfRect(btnMap["3500vChrButton"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 7 && StoryContainer.actTextbaustein >= 6)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1800vChrButton"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 9 && StoryContainer.actTextbaustein >= 7)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1044Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 10 && StoryContainer.actTextbaustein >= 9)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1180Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 14 && StoryContainer.actTextbaustein >= 10)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1450Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 15 && StoryContainer.actTextbaustein >= 14)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1608Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 17 && StoryContainer.actTextbaustein >= 15)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1712Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else if (StoryContainer.actTextbaustein < 19 && StoryContainer.actTextbaustein >= 17)
        {
            Vector2 value = calcMiddleOfRect(btnMap["1880Button"].GetComponent<RectTransform>());
            timelineMarkerFlare.anchorMin = value;
            timelineMarkerFlare.anchorMax = value;
        }
        else
        {
            timelineMarkerFlare.anchorMin = new Vector2(0, 0);
            timelineMarkerFlare.anchorMax = new Vector2(0, 0);
        }
    }

    private Vector2 calcMiddleOfRect(RectTransform origRec)
    {
        return new Vector2((origRec.anchorMax.x + origRec.anchorMin.x) / 2 - 0.003f, 0.5f);
    }
}
