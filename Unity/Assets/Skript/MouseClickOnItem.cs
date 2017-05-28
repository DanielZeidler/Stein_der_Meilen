using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClickOnItem : MonoBehaviour {

    public Texture2D cursorTexture;
    public Texture2D defaultTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public bool isClicked = false;

    private Vector2 cursorHotspot;
    

  
    void Start()
    {
        Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
    }

    public void OnMouseDown()
    {
        if(isClicked == false)
        {
            cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
            Cursor.SetCursor(cursorTexture, cursorHotspot, cursorMode);
            isClicked = true;
        }else if(isClicked == true)
        {
            Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
            isClicked = false;
        }
        
    }

}
