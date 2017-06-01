using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Dictionary<string, bool> buttonMap;
    public Dictionary<int, bool> minispielAccess;

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
        Button[] btnArray = GameObject.Find("ItemPanel").GetComponentsInChildren<Button>();
        //Initialisiere ErfindungenButtons
        if (buttonMap.Keys.Count == 0 && buttonMap != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    btnArray[n].interactable = true;
                    Instance.buttonMap.Add(btnArray[n].name, btnArray[n].interactable);
                }
            }
        }
        
    }
    void Update()
    {
        Button[] btnArray = GameObject.FindObjectsOfType<Button>();
        if (btnArray != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    btnArray[n].interactable = Instance.buttonMap[btnArray[n].name];
                }
            }
        }
        if(accessMinispiel0 && GameObject.Find("MinispieleButton") != null) GameObject.Find("MinispieleButton").GetComponent<Button>().interactable = true;

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
