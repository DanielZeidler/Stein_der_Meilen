using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickPause : MonoBehaviour {

    private void OnMouseDown()
    {
        if (StoryContainer.Instance.play)
        {
            StoryContainer.Instance.pause = true;
        }
    }
}
