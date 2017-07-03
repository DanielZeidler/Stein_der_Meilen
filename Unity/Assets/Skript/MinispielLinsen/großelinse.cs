using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class großelinse : MonoBehaviour, IDropHandler
{
    public GameObject linse;
    public GameObject richtig;

    public GameObject finish;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "große Konvexe Linse")
        {
            linse.SetActive(true);
            mittlerelinse.count++;

            if (mittlerelinse.count == 4)
            {
                finish.SetActive(true);
            }
        }
    }

}
