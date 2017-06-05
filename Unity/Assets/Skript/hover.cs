using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

    public Texture2D defaultTexture;
    public Texture2D pickupTexture;
    public CursorMode curMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(defaultTexture, hotSpot, curMode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        Cursor.SetCursor(pickupTexture, hotSpot, curMode);
    }

    private void OnMouseDown()
    {
        
    }

}
