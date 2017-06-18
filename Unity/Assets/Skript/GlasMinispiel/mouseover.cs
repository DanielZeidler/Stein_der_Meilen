using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class mouseover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject text;


    public void OnPointerEnter(PointerEventData eventData)
    {
        text.SetActive(true); ;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.SetActive(false);
    }
}
