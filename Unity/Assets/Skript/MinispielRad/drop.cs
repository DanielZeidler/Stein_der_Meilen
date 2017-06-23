using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class drop : MonoBehaviour, IDropHandler
{
    public bool kiste;
    public GameObject wirdsichtbar;
    public GameObject wirdzerstört;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("test");
        if(eventData.pointerDrag.name == "wagenohneKiste")
        {
            if(!kiste)
            {
                wirdsichtbar.SetActive(true);
                wirdzerstört.SetActive(false);
            }
        }

        if (eventData.pointerDrag.name == "wagenmitkiste")
        {
            if (kiste)
            {
                wirdsichtbar.SetActive(true);
                wirdzerstört.SetActive(false);
            }
        }
    }

}
