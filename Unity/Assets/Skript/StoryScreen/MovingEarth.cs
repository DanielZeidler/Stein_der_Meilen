using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEarth : MonoBehaviour {

    public float moving_Speed;
	
	// Update is called once per frame
	void Update () {
        if(StoryContainer.Instance.rotationEarth) GetComponent<Transform>().Rotate(0, 0, moving_Speed * Time.deltaTime, Space.Self);
	}
}
