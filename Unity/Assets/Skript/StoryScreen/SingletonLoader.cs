using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonLoader : MonoBehaviour {

    public GameManager gameManager;
    public StoryContainer storyContainer;

    void Awake () {
		if(GameManager.Instance == null)
        {
            Instantiate(gameManager);
        }
        if (StoryContainer.Instance == null)
        {
            Instantiate(storyContainer);
        }
    }
}
