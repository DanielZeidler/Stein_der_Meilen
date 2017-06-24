﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Siedlung : MonoBehaviour, IDropHandler
{
    public int count = 0;
    public GameObject wagen;

    public GameObject steinsiedlung;
    public GameObject wagenberg;

    public GameObject wagenwasser;

    public GameObject wagenholz;
    public GameObject holzsiedlung;

    public GameObject wagenfeld;

    public GameObject bewohnersiedlung;


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "wagenberg")
        {
            wagen.SetActive(true);
            steinsiedlung.SetActive(true);
            wagenberg.SetActive(false);
        }

        if (eventData.pointerDrag.name == "wagenwasser")
        {
            wagen.SetActive(true);
            count++;
            wagenwasser.SetActive(false);
        }

        if (eventData.pointerDrag.name == "wagenholz")
        {
            wagen.SetActive(true);
            holzsiedlung.SetActive(true);
            wagenholz.SetActive(false);
        }

        if (eventData.pointerDrag.name == "wagenfeld")
        {
            wagen.SetActive(true);
            count++;
            wagenfeld.SetActive(false);
        }

        if (count == 2)
        {
            bewohnersiedlung.SetActive(true);
        }
    }

}

