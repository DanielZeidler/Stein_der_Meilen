using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MühleDropzone : MonoBehaviour, IDropHandler
{
    public GameObject image;
    public CounterMuehle counter;



    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == gameObject.name)
        {
            eventData.pointerDrag.gameObject.SetActive(false);
            image.SetActive(true);
            counter.addCount();
        }

        if (counter.won())
        {
           
        }
    }

}

