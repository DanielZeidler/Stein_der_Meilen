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
        Debug.Log(StoryContainer.actTextbaustein);
        if (StoryContainer.Instance.play)
        {
            StoryContainer.Instance.play = false;
            StoryContainer.Instance.pause = false;
        }
        else if(StoryContainer.actTextbaustein < StoryContainer.Instance.textbausteine.Length - 1 && StoryContainer.actTextbaustein < StoryContainer.accessStoryPart)
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
