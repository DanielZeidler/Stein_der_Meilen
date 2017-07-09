using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class schalter : MonoBehaviour, IDropHandler
{
    public GameObject texti;
    public GameObject schalterm;

    public GameObject finish;

    public GameObject text;

    public static bool schalterd = false;
    public static bool schaltertext = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "schalter")
        {
            schalterm.SetActive(true);
            schalterd = true;
            texti.SetActive(false);

        }

        if (eventData.pointerDrag.name == "schaltertext")
        {
            text.SetActive(true);
            schaltertext = true;

        }

        if (dampf.dampfd && dampf.dampftext && schalter.schalterd && schalter.schaltertext && lampe.lamped && lampe.lampetext && leiter.leitertext)
        {
            finish.SetActive(true);
            GameManager.Instance.finishMinispiel10 = true;
        }
    }

}
