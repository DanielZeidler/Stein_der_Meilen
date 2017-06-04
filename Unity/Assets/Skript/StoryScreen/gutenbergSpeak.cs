using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gutenbergSpeak : MonoBehaviour {

    Animator animator;
    SpriteRenderer renderer;

    void Awake()
    {
        animator = GameObject.Find("gutenberg").GetComponent<Animator>();
        renderer = GameObject.Find("gutenberg").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if(StoryContainer.actTextbaustein == 12)
        {
            renderer.enabled = true;
        }
        else
        {
            renderer.enabled = false;
        }
        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause && StoryContainer.actTextbaustein == 12)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
