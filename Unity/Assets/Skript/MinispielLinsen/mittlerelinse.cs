using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class mittlerelinse : MonoBehaviour, IDropHandler
{
    public GameObject linse;
    public GameObject richtig;


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "mittlere konkave Linse")
        {
            linse.SetActive(true);
            richtig.SetActive(false);
        }
    }

}
