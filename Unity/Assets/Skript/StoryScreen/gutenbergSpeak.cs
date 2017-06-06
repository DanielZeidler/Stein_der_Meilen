using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gutenbergSpeak : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spRenderer;

    void Awake()
    {
        animator = GameObject.Find("gutenberg").GetComponent<Animator>();
        spRenderer = GameObject.Find("gutenberg").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if(StoryContainer.actTextbaustein == 12)
        {
            spRenderer.enabled = true;
        }
        else
        {
            spRenderer.enabled = false;
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
