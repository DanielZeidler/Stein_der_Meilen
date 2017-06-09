using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickMute : MonoBehaviour {

    void OnMouseDown()
    {
        StoryContainer.Instance.mute = true;

    }
}
