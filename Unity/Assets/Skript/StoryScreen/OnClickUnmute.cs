using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickUnmute : MonoBehaviour {

    void OnMouseDown()
    {
        StoryContainer.Instance.mute = false;

    }
}
