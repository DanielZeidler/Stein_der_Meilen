using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class galilei : MonoBehaviour, IDropHandler
{
    public GameObject virtuell2;

    public GameObject aufrecht2;

    public GameObject seitenrichtig2;

    public GameObject vergrößert2;

    public static int galil = 0;

    public GameObject finish;

    private bool was1 = true;
    private bool was2 = true;
    private bool was3 = true;
    private bool was4 = true;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "virtuell" && was1)
        {
            virtuell2.SetActive(true);
            galil++;
            was1 = false;
        }

        if (eventData.pointerDrag.name == "aufrecht" && was2)
        {
            aufrecht2.SetActive(true);
            galil++;
            was2 = false;
        }

        if (eventData.pointerDrag.name == "seitenrichtig" && was3)
        {
            seitenrichtig2.SetActive(true);
            galil++;
            was3 = false;
        }

        if (eventData.pointerDrag.name == "vergrößert" && was4)
        {
            vergrößert2.SetActive(true);
            galil++;
            was4 = false;
        }

        if (mittlerelinse.count == 4 && galilei.galil == 4 && kepler.keple == 4)
        {
            finish.SetActive(true);

            GameManager.Instance.finishMinispiel8 = true;
            
        }
    }

}
