using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool reset = false;

    private Dictionary<string, bool> buttonMap;
    public Dictionary<int, bool> minispielAccess;

    public Scene actScene;
    
    public bool accessMinispiel0 = false;
    public bool accessMinispiel1 = false;
    public bool accessMinispiel2 = false;
    public bool accessMinispiel3 = false;
    public bool accessMinispiel4= false;
    public bool accessMinispiel5= false;
    public bool accessMinispiel6= false;
    public bool accessMinispiel7= false;
    public bool accessMinispiel8= false;
    public bool accessMinispiel9= false;
    public bool accessMinispiel10= false;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get { return _instance; }
    }
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            buttonMap = new Dictionary<string, bool>();
            minispielAccess = new Dictionary<int, bool>();
            
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        GameObject[] btnArray = GameObject.FindGameObjectsWithTag("ErfindungButton");
        //Initialisiere ErfindungenButtons
        if (buttonMap.Keys.Count == 0 && buttonMap != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    Button btn = btnArray[n].GetComponent<Button>();
                    btn.interactable = false;
                    Instance.buttonMap.Add(btnArray[n].name, btn.interactable);
                }
            }
        }
        actScene = SceneManager.GetActiveScene();
    }
    void Update()
    {
        if (reset)
        {
            accessMinispiel0 = false;
            accessMinispiel1 = false;
            accessMinispiel2 = false;
            accessMinispiel3 = false;
            accessMinispiel4 = false;
            accessMinispiel5 = false;
            accessMinispiel6 = false;
            accessMinispiel7 = false;
            accessMinispiel8 = false;
            accessMinispiel9 = false;
            accessMinispiel10 = false;

            reset = false;
        }

        if(accessMinispiel0 && StoryScreenInteractionController.Instance.minispieleButton != null) StoryScreenInteractionController.Instance.minispieleButton.interactable = true;

        if (StoryScreenInteractionController.erfindungenButtonMap != null && actScene.name == "StoryScreen") 
        {
            foreach (Button btn in StoryScreenInteractionController.erfindungenButtonMap.Values) buttonMap[btn.name] = btn.interactable;
        }
        
    }

    public bool setErfindungButtonInteractable(string buttonName, bool value)
    {
        bool state = false;
        if (Instance.buttonMap.ContainsKey(buttonName))
        {
            Instance.buttonMap[buttonName] = value;

            if (Instance.buttonMap[buttonName] == value) state = true;
        }
        return state;
    }

    public bool removeErfindungsButton(string buttonName)
    {
        if (Instance.buttonMap.ContainsKey(buttonName))
        {
            return Instance.buttonMap.Remove(buttonName);
        }
        else return false;
    }
}
