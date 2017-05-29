using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryContainer : MonoBehaviour
{
    
    public string[] textbausteine;
    private Dictionary<int, string[]> paragraphen;



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
            paragraphen = new Dictionary<int, string[]>();
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        string[] tmp = new string[4];
        for (int i = 0, n=0; i <= 3; i++,n++)
        {
            tmp[n]= textbausteine[i];
        }
        
        paragraphen.Add(1, tmp);

        tmp = new string[4];
        for (int i = 4,n=0; i <= 7; i++,n++)
        {
            tmp[n] = textbausteine[i];
        }
        paragraphen.Add(2, tmp);

        tmp = new string[6];
        for (int i = 8, n=0; i <= 13; i++,n++)
        {
            tmp[n] = textbausteine[i];
        }
        paragraphen.Add(3, tmp);

        tmp = new string[7];
        for (int i = 14, n=0; i <= 20; i++,n++)
        {
            tmp[n] = textbausteine[i];
        }
        paragraphen.Add(4, tmp);

        foreach(int i in paragraphen.Keys)
        {
            foreach (string s in paragraphen[i])
            {
                Debug.Log(s);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}