using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class see : MonoBehaviour, IDropHandler
{
    public bool dragged = false;
    public GameObject wegsee1;
    public GameObject wegsee2;
    public GameObject wagenmit;
    public GameObject wagenmit2;
    public GameObject wagenohne;
    public GameObject wagenohne2;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "wagenohnekiste" && !dragged)
        {
            wegsee1.SetActive(true);
            wagenmit.SetActive(true);
            wagenohne.transform.position = new Vector3(818.4512f, 228.2585f, 0f);
            wagenohne.SetActive(false);
            dragged = true;
        }

        if (eventData.pointerDrag.name == "wagenohnekistesee")
        {
            wegsee2.SetActive(true);
            wagenmit2.SetActive(true);
            wagenohne2.SetActive(false);
        }
    }

}

