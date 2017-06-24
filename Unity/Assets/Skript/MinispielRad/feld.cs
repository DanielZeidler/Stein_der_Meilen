using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class feld : MonoBehaviour, IDropHandler
{
    public bool dragged = false;
    public GameObject wegfeld;
    public GameObject großesfeld;
    public GameObject wagenmit;
    public GameObject wagenmit2;
    public GameObject wagenohne;
    public GameObject wagenohne2;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "wagenohnekiste" && !dragged)
        {
            wegfeld.SetActive(true);
            wagenohne2.SetActive(true);
            wagenohne.transform.position = new Vector3(436.7f, 126.2f, 0);
            wagenohne.SetActive(false);
            dragged = true;
        }

        if (eventData.pointerDrag.name == "wagenwasser2")
        {
            wagenmit.SetActive(true);
            großesfeld.SetActive(true);
            wagenohne2.SetActive(false);
            wagenmit2.SetActive(false);
        }
    }

}
