using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class wald : MonoBehaviour, IDropHandler
{
    public bool dragged = false;
    public GameObject wegwald;
    public GameObject wagenmit;
    public GameObject wagenohne;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "wagenohnekiste" && !dragged)
        {
            wegwald.SetActive(true);
            wagenmit.SetActive(true);
            wagenohne.transform.position = new Vector3(613.6133f, 152.1723f, 0f);
            wagenohne.SetActive(false);
            dragged = true;
        }
    }

}
