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
        if (eventData.pointerDrag.name == "Feldspat")
        {
            countF++;

            if (countF % 3 > 0 )
            {
                add(0.1f);
            }
            
            else
            {
                countF = 1;
                reset(1);
            }
        }

        if (eventData.pointerDrag.name == "Kalk")
        {
            countK++;

            if (countK % 3 > 0)
            {
                add(0.1f);
            }

            else
            {
                countK = 1;
                reset(2);
            }
        }

        if (eventData.pointerDrag.name == "Pottasche")
        {
            countP++;

            if (countP % 2 > 0)
            {
                add(0.1f);
            }

            else
            {
                countP = 1;
                reset(3);
            }
        }

        if (eventData.pointerDrag.name == "Quarz")
        {
            countQ++;

            if (countQ % 5 > 0)
            {
                add(0.1f);
            }

            else
            {
                countQ = 1;
                reset(4);
            }
        }

        if (eventData.pointerDrag.name == "Soda")
        {
            countS++;

            if (countS % 2 > 0)
            {
                add(0.1f);
            }

            else
            {
                countS = 1;
                reset(5);
            }

        }
    }

    public void add(float value)
    {
        if (progression + value > 0.95f)
        {
            Debug.Log("finish");
            progress.size = 0;
        }

        progression += value;
        progress.size = progression;

        
    }

    public void reset(int numb)
    {
        switch(numb)
        {
            case 1:
                countK = countP = countQ = countS = 0;
                break;

            case 2:
                countF = countP = countQ = countS = 0;
                break;

            case 3:
                countK = countF = countQ = countS = 0;
                break;

            case 4:
                countK = countP = countF = countS = 0;
                break;

            case 5:
                countK = countP = countQ = countF = 0;
                break;
        }

        progression = 1/10f;
        progress.size = progression;
    }
}
