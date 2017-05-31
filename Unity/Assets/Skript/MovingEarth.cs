using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEarth : MonoBehaviour {

    public float moving_Speed;
    Vector3 rotationTransform;
	// Use this for initialization
	void Start () {
        rotationTransform = new Vector3(0, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().Rotate(0, 0, moving_Speed * Time.deltaTime, Space.Self);
	}
}
