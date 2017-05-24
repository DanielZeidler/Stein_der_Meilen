using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLoader : MonoBehaviour {

    public GameManager gameManager;
	
	void Awake () {
		if(GameManager.instance == null)
        {
            Instantiate(gameManager);
        }
	}
	
}
