using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MühleDropzone : MonoBehaviour, IDropHandler{


	public GameObject image;
	public CounterMuehle counter;



	public void OnDrop (PointerEventData eventData)
	{
		
		print (eventData.pointerDrag.name);
		print ("dropped on");
		print (gameObject.name);

		if (eventData.pointerDrag.name == gameObject.name)
		{
			print ("match");
			print ("----------");
			eventData.pointerDrag.gameObject.SetActive (false);
			image.SetActive (true);
			counter.addCount ();
		}

		if (counter.won ()) {
			// WON THE GAME
			print("won the Muehle Game");


			// TODO Implement Game Won

		}
	}
}