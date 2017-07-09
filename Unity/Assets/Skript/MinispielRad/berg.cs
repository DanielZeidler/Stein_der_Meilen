using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class berg : MonoBehaviour, IDropHandler
{
    public bool dragged = false;
    public GameObject wegberg;
    public GameObject wagenmit;
    public GameObject wagenohne;

    public void OnDrop (PointerEventData eventData)
    {
        if(eventData.pointerDrag.name == "wagenohnekiste" && !dragged)
        {
            wegberg.SetActive(true);
            wagenmit.SetActive(true);
            wagenohne.transform.position = new Vector3(818.4512f, 228.2585f, 0f);
            wagenohne.SetActive(false);
            dragged = true;
        }
    }

}
