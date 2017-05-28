using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testToggleItem : MonoBehaviour {

    public string targetName;
    public bool value;

    private GameManager gamMan;

    private void Start()
    {
        gamMan = GameManager.Instance;
    }

    private void OnMouseDown()
    {
        toggleButtonInteractable();
    }

    public void toggleButtonInteractable()
    {
        if (gamMan.getButtonMap().ContainsKey(targetName))
        {
            gamMan.toggleErfindungButtonInteractable(targetName);
        }
    }
}
