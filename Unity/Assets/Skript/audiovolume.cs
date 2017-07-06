using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiovolume : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioListener.volume = PlayerPrefs.GetFloat("audio");
	}
}
