﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnClickPlay : MonoBehaviour {

    public string[] paragraph;
    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
        
    }

    private void OnMouseDown()
    {
        if (!StoryContainer.Instance.play && !StoryContainer.Instance.pause)
        {
            StoryContainer.Instance.play = true;
            StoryContainer.Instance.setText();
        }else if(StoryContainer.Instance.play && StoryContainer.Instance.pause)
        {
            StoryContainer.Instance.pause = false;
        }
    }

}
