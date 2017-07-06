using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

	public void resetGameData()
    {
        if(gameObject.GetComponentInChildren<Text>().text == "LeaveGame")
        {
            StoryScreenInteractionController.start = true;
            GameManager.Instance.reset = true;
            StoryContainer.Instance.reset = true;

            SceneManager.LoadScene("StoryScreen", LoadSceneMode.Single);
            gameObject.GetComponentInChildren<Text>().text = "StartGame";
        }
        else
        {
            StoryScreenInteractionController.start = false;
            StoryContainer.Instance.play = true;
            StoryScreenInteractionController.Instance.setText();
            gameObject.GetComponentInChildren<Text>().text = "LeaveGame";
            StoryScreenInteractionController.Instance.backgroundMusic.Play();
        }
    }

    private void Update()
    {
        if (StoryScreenInteractionController.start)
        {
            gameObject.GetComponentInChildren<Text>().text = "StartGame";
        }
        else
        {
            gameObject.GetComponentInChildren<Text>().text = "LeaveGame";
        }
    }
}
