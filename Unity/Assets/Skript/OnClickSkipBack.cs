using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSkipBack : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }


    private void OnMouseDown()
    {
        Debug.Log("SkipBack");

        if (StoryContainer.Instance.play)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
        }
        else if (StoryContainer.actParagraph > 0)
        {
            StoryContainer.actParagraph--;
            StoryContainer.Instance.play = true;
            StoryContainer.Instance.pause = false;
            StoryContainer.Instance.setText();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
