using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerInitiator : MonoBehaviour {

    public Texture2D defaultTexture;
    public CursorMode cursorMode;
    public Vector2 hotSpot = Vector2.zero;

    private Vector2 cursorHotspot;

    private void Awake()
    {
        cursorMode = CursorMode.ForceSoftware;
        Cursor.SetCursor(defaultTexture, hotSpot, CursorMode.ForceSoftware);
    }
    
}
