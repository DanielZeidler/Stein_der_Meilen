using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour {

    public float waitUntilLoadStory;

    private void Start()
    {
        StartCoroutine(loadStoryScreen());
    }

    private IEnumerator loadStoryScreen()
    {
        yield return new WaitForSeconds(waitUntilLoadStory);
        SceneManager.LoadScene("StoryScreen", LoadSceneMode.Single);
    }
}
