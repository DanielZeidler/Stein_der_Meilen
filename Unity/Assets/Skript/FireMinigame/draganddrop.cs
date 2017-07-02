using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]

public class draganddrop : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public GameObject obj;

    public bool drag = false;


    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        drag = true;

    }

    void OnMouseDrag()
    {
        if (drag)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
        
    }

    void OnMouseUp()
    {
        drag = false;
    }
}