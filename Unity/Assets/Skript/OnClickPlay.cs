using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnClickPlay : MonoBehaviour {

    public string[] paragraph;
    private int actPara = -1;
    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
        
    }

    private void OnMouseDown()
    {
        
        StoryContainer.Instance.play = !StoryContainer.Instance.play;
        StoryContainer.Instance.setText();
    }

}
