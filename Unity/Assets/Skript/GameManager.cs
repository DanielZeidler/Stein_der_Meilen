using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;
    public  Dictionary<string,bool> buttonMap;

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

            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(GameObject.Find("ItemPanel"));
        }
        else if(_instance != this){
            Destroy(gameObject);
        }
    }

    void Start () {
        Button[] btnArray = GameObject.Find("ItemPanel").GetComponentsInChildren<Button>();
        //Initialisiere ErfindungenButtons
        if (buttonMap.Keys.Count == 0 && buttonMap != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    btnArray[n].interactable = false;
                    Instance.buttonMap.Add(btnArray[n].name, btnArray[n].interactable);
                }
            }
        }
        
    }

	void Update () {
        Button[] btnArray = GameObject.FindObjectsOfType<Button>();
        if(btnArray != null)
        {
            for (int n = 0; n < btnArray.Length; n++)
            {
                if (btnArray[n].tag == "ErfindungButton")
                {
                    btnArray[n].interactable = Instance.buttonMap[btnArray[n].name];
                }
            }
        }
      
    }


    public void toggleErfindungButtonInteractable(string buttonName)
    {
        if (Instance.buttonMap.ContainsKey(buttonName))
        {
            Instance.buttonMap[buttonName] = !Instance.buttonMap[buttonName];
        }
        else
        {
            Debug.Log("Kein 'ErfindungButton' mit Namen: " + buttonName);
        }
    }
    public void setErfindungButtonInteractable(string buttonName,bool value)
    {
        if (Instance.buttonMap.ContainsKey(buttonName))
        {
            Instance.buttonMap[buttonName] = value;
        }else
        {
            Debug.Log("Kein 'ErfindungButton' mit Namen: " + buttonName);
        }
    }

}
