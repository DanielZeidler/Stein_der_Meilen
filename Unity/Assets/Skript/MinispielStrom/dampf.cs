using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dampf : MonoBehaviour, IDropHandler
{
    public GameObject texti;

    public GameObject dampfm;

    public GameObject finish;

    public GameObject text;

    public static bool dampfd = false;
    public static bool dampftext = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "dampfmasch")
        {
            dampfm.SetActive(true);
            dampfd = true;
            texti.SetActive(false);

        }

        if (eventData.pointerDrag.name == "dampftext")
        {
            text.SetActive(true);
            dampftext = true;

        }

        if (dampf.dampfd && dampf.dampftext && schalter.schalterd && schalter.schaltertext && lampe.lamped && lampe.lampetext && leiter.leitertext)
        {
            finish.SetActive(true);
        }
    }

}
