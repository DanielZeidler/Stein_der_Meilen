using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class davinciSpeak : MonoBehaviour {

    Animator animator;

    void Awake()
    {
        animator = GameObject.Find("davinci").GetComponent<Animator>();
    }
    private void Start()
    {
        animator.StopPlayback();
    }
    void Update()
    {
        if (StoryContainer.Instance.play && !StoryContainer.Instance.pause)
        {
            animator.StopPlayback();
        }
        else
        {
            animator.StartPlayback();
        }
    }
}
