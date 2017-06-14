using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Vector3 positionToReturnTo;

    public void OnBeginDrag(PointerEventData eventData)
    {
        positionToReturnTo = this.transform.position;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = positionToReturnTo;
        Debug.Log("OnEndDrag");
    }
}
