using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edisonSpeak : MonoBehaviour
{

    private Animator animator;
    private SpriteRenderer spRenderer;

    void Awake()
    {
        animator = GameObject.Find("edison").GetComponent<Animator>();
        spRenderer = GameObject.Find("edison").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.actTextbaustein == 19)
        {
            spRenderer.enabled = true;
        }
        else
        {
            spRenderer.enabled = false;
        }
        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause && StoryContainer.actTextbaustein == 19)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
