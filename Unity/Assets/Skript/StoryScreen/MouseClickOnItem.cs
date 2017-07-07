using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClickOnItem : MonoBehaviour {

    public Texture2D cursorTexture;
    public Texture2D defaultTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;
    public bool isClicked = false;
    private StoryScreenInteractionController sSIC;
    private Vector2 cursorHotspot;

    private Button[] erfindungenButtonArray;

    private void Awake()
    {
        Cursor.SetCursor(defaultTexture, hotSpot, CursorMode.ForceSoftware);
        sSIC = GameObject.Find("InfoBoxImage").GetComponent<StoryScreenInteractionController>();
        erfindungenButtonArray = GameObject.FindObjectsOfType<Button>();
    }

    public void OnMouseDown()
    {

        foreach(Button btn in erfindungenButtonArray)
        {
            if(btn.tag == "ErfindungButton")
            {
                if (btn.GetComponent<MouseClickOnItem>().isClicked && btn.gameObject.name != gameObject.name) btn.GetComponent<MouseClickOnItem>().isClicked = false;
            }
            
        }
        if (isClicked == false)
        {
            cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
            Cursor.SetCursor(cursorTexture, cursorHotspot, cursorMode);
            isClicked = true;
        }else if(isClicked == true)
        {
            Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
            isClicked = false;
        }
        
        foreach(Button btn in GameObject.FindObjectsOfType<Button>())
        {
            if(btn.tag != "ErfindungButton")
            {
                btn.onClick.AddListener(delegate {
                    Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
                    isClicked = false;
                });
            }
        }
        sSIC.setButtonInteraction();
    }

}
