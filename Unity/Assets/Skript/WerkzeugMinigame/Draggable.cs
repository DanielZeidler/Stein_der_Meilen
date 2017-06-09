using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

	public enum Art {AXT, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, STEIN, WASSER, KEIN}; // Enum fuer Art des Werkzeuges
	public Art werkzeug = Art.KEIN;

	public void OnBeginDrag (PointerEventData eventData) {
		
		//Debug.Log("OnBeginDrag");

		parentToReturnTo = this.transform.parent; // Speichert Parent des Werkzeuges um es evtl wieder zurueckzubringen
		this.transform.SetParent (this.transform.parent.parent); // Aendert Parent

		GetComponent<CanvasGroup> ().blocksRaycasts = false;

	}

	public void OnDrag (PointerEventData eventData) {

		//Debug.Log("OnDrag");

		this.transform.position = eventData.position;  // Position neu setzen (Maus)

	}

	public void OnEndDrag (PointerEventData eventData) {

		//Debug.Log("EndDrag");
		this.transform.SetParent (parentToReturnTo); // Setzt Parent zurueck, falls es nicht gepasst hat
		GetComponent<CanvasGroup> ().blocksRaycasts = true;

	}

	public void destroyMe () {
		Destroy(this.gameObject);
	}
}
