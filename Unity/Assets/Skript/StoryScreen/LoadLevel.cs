using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
    
    public string scene;

    private void OnMouseDown()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        if(scene.Length > 0)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
}
        
    }
}
