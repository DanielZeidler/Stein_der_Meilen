using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edisonSpeak : MonoBehaviour
{

    Animator animator;
    SpriteRenderer renderer;

    void Awake()
    {
        animator = GameObject.Find("edison").GetComponent<Animator>();
        renderer = GameObject.Find("edison").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.actTextbaustein == 18)
        {
            renderer.enabled = true;
        }
        else
        {
            renderer.enabled = false;
        }
        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause && StoryContainer.actTextbaustein == 18)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
