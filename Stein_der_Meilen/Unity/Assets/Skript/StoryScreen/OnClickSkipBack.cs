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
        if (StoryContainer.Instance.play)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
        }
        else if (StoryContainer.actTextbaustein > 0)
        {
            StoryContainer.actTextbaustein--;
            StoryContainer.Instance.play = true;
            StoryContainer.Instance.pause = false;
            StoryScreenInteractionController.Instance.setText();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
