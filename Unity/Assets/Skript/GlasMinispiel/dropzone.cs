using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropzone : MonoBehaviour, IDropHandler
{
    public Scrollbar progress;
    public float progression = 0;

    public int countF;
    public int countK;
    public int countP;
    public int countQ;
    public int countS;

    public void OnDrop (PointerEventData eventData)
     {
         Debug.Log (eventData.pointerDrag.name);

        if (eventData.pointerDrag.name == "Feldspat")
        {
            countF++;
        }

        if (eventData.pointerDrag.name == "Kalk")
        {
            countK++;
        }

        if (eventData.pointerDrag.name == "Pottasche")
        {
            countP++;
        }

        if (eventData.pointerDrag.name == "Quarz")
        {
            countQ++;
        }

        if (eventData.pointerDrag.name == "Soda")
        {
            countS++;
            
        }

        if (progression == 100)
        {
            Debug.Log("finish");
        }
    }

    public void add(float value)
    {
        progression += value;
        progress.size = progression / 100f;
    }
}
