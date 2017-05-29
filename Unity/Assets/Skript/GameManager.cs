using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;
    private Dictionary<string,Button> buttonMap = null;

    public static GameManager Instance
    {
        get { return _instance; }
    }


    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            buttonMap = new Dictionary<string, Button>();
            DontDestroyOnLoad(gameObject);
        }
        else if(_instance != this){
            Destroy(gameObject);
        }
    }

    void Start () {
        Button[] btnArray = GameObject.Find("ItemPanel").GetComponentsInChildren<Button>();
        //Initialisiere ErfindungenButtons
        if (Instance.buttonMap.Keys.Count == 0 && Instance.buttonMap != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    btnArray[n].interactable = false;
                    Instance.buttonMap.Add(btnArray[n].name, btnArray[n]);
                }
            }
        }
        
    }

	void Update () {
        Button[] btnArray = GameObject.FindObjectsOfType<Button>();
        for (int n = 0; n < btnArray.Length; n++)
        {
            if (btnArray[n].tag == "ErfindungButton")
            {
                btnArray[n].interactable = buttonMap[btnArray[n].name].interactable;
            }
        }
      
    }


    public void setErfindungButtonInteractable(string buttonName, bool boolean)
    {
        Instance.buttonMap[buttonName].interactable = boolean;
    }

    public void toggleErfindungButtonInteractable(string buttonName)
    {
        Instance.buttonMap[buttonName].interactable = !Instance.buttonMap[buttonName].interactable;
    }

    public Dictionary<string, Button> getButtonMap()
    {
        return Instance.buttonMap;
    }
}
