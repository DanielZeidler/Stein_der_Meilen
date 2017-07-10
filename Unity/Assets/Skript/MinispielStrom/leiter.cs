using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class leiter : MonoBehaviour, IDropHandler
{
    public GameObject texti;
    public GameObject finish;

    public GameObject text;

    public static bool leitertext = false;

    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag.name == "leitertext")
        {
            text.SetActive(true);
            leitertext = true;
            texti.SetActive(false);

        }

        if (dampf.dampfd && dampf.dampftext && schalter.schalterd && schalter.schaltertext && lampe.lamped && lampe.lampetext && leiter.leitertext)
        {
            finish.SetActive(true);
            GameManager.Instance.finishMinispiel10 = true;
        }
    }

}
