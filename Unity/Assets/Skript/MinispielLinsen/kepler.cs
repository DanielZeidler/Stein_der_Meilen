using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class kepler : MonoBehaviour, IDropHandler
{
    public GameObject reell3;

    public GameObject kopfstehend3;

    public GameObject seitenverkehrt3;

    public GameObject vergrößert3;

    public static int keple = 0;

    public GameObject finish;

    private bool was1 = true;
    private bool was2 = true;
    private bool was3 = true;
    private bool was4 = true;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "reell" && was1)
        {
            reell3.SetActive(true);
            keple++;
            was1 = false;
        }

        if (eventData.pointerDrag.name == "kopfstehend" && was2)
        {
            kopfstehend3.SetActive(true);
            keple++;
            was2 = false;
        }

        if (eventData.pointerDrag.name == "seitenverkehrt" && was3)
        {
            seitenverkehrt3.SetActive(true);
            keple++;
            was3 = false;
        }

        if (eventData.pointerDrag.name == "vergrößert" && was4)
        {
            vergrößert3.SetActive(true);
            keple++;
            was4 = false;
        }

        if (mittlerelinse.count == 4 && galilei.galil == 4 && kepler.keple == 4)
        {
            finish.SetActive(true);
        }
    }

}
