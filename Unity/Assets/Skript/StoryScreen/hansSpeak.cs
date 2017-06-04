using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hansSpeak : MonoBehaviour {

    Animator animator;
    SpriteRenderer renderer;

    void Awake()
    {
        animator = GameObject.Find("lipperhey").GetComponent<Animator>();
        renderer = GameObject.Find("lipperhey").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.actTextbaustein == 15)
        {
            renderer.enabled = true;
        }
        else
        {
            renderer.enabled = false;
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
