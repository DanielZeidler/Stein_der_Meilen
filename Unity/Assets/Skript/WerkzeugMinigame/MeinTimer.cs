using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeinTimer : ScriptableObject{

	private static MeinTimer instance;

	private MeinTimer() {}

	public static MeinTimer Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new MeinTimer();
			}
			return instance;
		}
	}


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
