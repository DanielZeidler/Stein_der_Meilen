using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class davinciSpeak : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spRenderer;

    void Awake()
    {
        animator = GameObject.Find("davinci").GetComponent<Animator>();
        spRenderer = GameObject.Find("davinci").GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.actTextbaustein != 12 && StoryContainer.actTextbaustein != 15 && StoryContainer.actTextbaustein != 18)
        {
            spRenderer.enabled = true;
        }
        else
        {
            spRenderer.enabled = false;
        }

        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause && StoryContainer.actTextbaustein != 12 && StoryContainer.actTextbaustein != 15 && StoryContainer.actTextbaustein != 18)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
