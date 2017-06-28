using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class textiweg : MonoBehaviour, IBeginDragHandler
{

    public Vector3 positionToReturnTo;
    public GameObject text;

    public void OnBeginDrag(PointerEventData eventData)
    {
        text.SetActive(false);
    }
}
