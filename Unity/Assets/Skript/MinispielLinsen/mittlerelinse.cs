using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class mittlerelinse : MonoBehaviour, IDropHandler
{
    public GameObject linse;
    public GameObject richtig;
    public static int count = 0;
    public GameObject finish;
    public GameObject text;

    private bool was1 = true;


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "mittlere konkave Linse" && was1)
        {
            linse.SetActive(true);
            mittlerelinse.count++;
            was1 = false;

            if (mittlerelinse.count == 1)
            {
                text.SetActive(false);
            }
        }

        if (mittlerelinse.count == 4 && galilei.galil == 4 && kepler.keple == 4)
        {
            finish.SetActive(true);
        }
    }

}
