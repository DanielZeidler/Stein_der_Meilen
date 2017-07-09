using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class lampe : MonoBehaviour, IDropHandler
{
    public GameObject texti;
    public GameObject lampem;

    public GameObject finish;

    public GameObject text;

    public static bool lamped = false;
    public static bool lampetext = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "lampe")
        {
            lampem.SetActive(true);
            lamped = true;
            texti.SetActive(false);

        }

        if (eventData.pointerDrag.name == "lampetext")
        {
            text.SetActive(true);
            lampetext = true;

        }

        if (dampf.dampfd && dampf.dampftext && schalter.schalterd && schalter.schaltertext && lamped && lampetext && leiter.leitertext)
        {
            finish.SetActive(true);
        }
    }

}
