using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortschritt : ScriptableObject{

	private static Fortschritt instance;

	private Fortschritt() {}

	public static Fortschritt Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new Fortschritt();
			}
			return instance;
		}
	}


	private int gameFortschritt = 0; // Spielfortschritt
	private bool meatDone = false;
	private bool fireBuild = false;
	private bool wolle = false;
	private bool brotDone = false;

	public void setMeatDone (bool wert){
		meatDone = wert;
	}

	public void setFireBuild (bool wert){
		fireBuild = wert;
	}

	public void setWolle (bool wert){
		wolle = wert;
	}

	public void setBrotDone (bool wert){
		brotDone = wert;
	}

	public bool getMeatDone () {
		return meatDone;
	}

	public bool getFireBuild () {
		return fireBuild;
	}
	public bool getWolle () {
		return wolle;
	}
	public bool getBrotDone () {
		return brotDone;
	}

	public int getGameFortschritt() {
		return gameFortschritt;
	}

	public void setGameFortschritt(int fortschritt) {
		gameFortschritt += fortschritt;
	}
}