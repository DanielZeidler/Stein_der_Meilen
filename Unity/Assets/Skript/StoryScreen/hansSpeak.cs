using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hansSpeak : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spRenderer;

    void Awake()
    {
        animator = GameObject.Find("lipperhey").GetComponent<Animator>();
        spRenderer = GameObject.Find("lipperhey").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.actTextbaustein == 15)
        {
            spRenderer.enabled = true;
        }
        else
        {
            spRenderer.enabled = false;
        }
        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause && StoryContainer.actTextbaustein == 15)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
