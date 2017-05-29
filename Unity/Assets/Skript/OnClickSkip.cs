using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSkip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    private void OnMouseDown()
    {
        if(StoryContainer.actParagraph < StoryContainer.Instance.paragraphen.Keys.Count -1)
        StoryContainer.actParagraph++;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
