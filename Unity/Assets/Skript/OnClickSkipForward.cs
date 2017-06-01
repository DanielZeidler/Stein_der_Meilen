using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickSkipForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    private void OnMouseDown()
    {
        if (StoryContainer.Instance.play)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
        }
        else if(StoryContainer.actTextbaustein < StoryContainer.Instance.textbausteine.Length - 1 && StoryContainer.actStoryPart +1 < StoryContainer.Instance.getAccessStoryPart())
        {
            StoryContainer.actTextbaustein++;
            StoryContainer.Instance.play = true;
            StoryContainer.Instance.pause = false;
            StoryContainer.Instance.setText();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
