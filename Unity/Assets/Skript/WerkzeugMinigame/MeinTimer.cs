using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeinTimer : MonoBehaviour{

	// TODO Singleton implem wie in fortschritt


	public static float timer = 0f; // Float fuer Timer

	void Update() {
		// Timer

		timer = timer + Time.deltaTime;

		//print(timer);


	}

	public void setTimer (float newTime) {
		timer = newTime;
	}

	public float getTimer () {
		return timer;
	}
}
