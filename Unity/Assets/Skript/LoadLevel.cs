using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {


    public void LoadScene(string scene)
    {
       SceneManager.LoadScene("Assets/Save/"+scene+".unity", LoadSceneMode.Single);  
    }
}
