using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testToggleItem : MonoBehaviour {

    public string targetName;
    public bool value;
    

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        GameManager.Instance.toggleErfindungButtonInteractable(targetName);
    }

   
}
