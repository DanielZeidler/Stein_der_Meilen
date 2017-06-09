using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public int healthCount = 2; // Lebenspunkte fuer Baeume
	public int gameFortschritt = 0; // Spielfortschritt
	public bool meatDone = false;
	public bool fireBuild = false;
	public bool wolle = false;
	public bool brotDone = false;

	public enum Passend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, NONE}; // ENUM fuer Werkzeuge die gehen
	public Passend destroy = Passend.NONE; // InitialWerkzeug

	public enum AuchPassend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, NONE}; // Weitere Werkzeuge die gehen
	public AuchPassend tooDestroy = AuchPassend.NONE; // Initital Alternativ Werkzeug


	public void OnPointerEnter (PointerEventData eventData) {
		//Debug.Log ("OnPointerEnter to " + gameObject.name);

	}


	public void OnDrop (PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dragged to " + gameObject.name);

		Vector3 objPos = this.gameObject.transform.position;  // Position des Objekts, auf das gezogen wurde

		if (eventData.eligibleForClick) {
			Draggable d = eventData.pointerDrag.GetComponent<Draggable> (); // Gezogenes Werkzeug
			if(destroy.ToString() == d.werkzeug.ToString() || tooDestroy.ToString() == d.werkzeug.ToString()) { // Wenn Werkzeug Objekt bearbeiten kann



				///////////////////////
				// --- GAME LOGIC -- //
				///////////////////////

				if (gameObject.name == "Schaf") {



						// Brutzel Sound


						GameObject.Find("Wolle").transform.position = objPos;
						// Spielfortschritt
						wolle = true;
						gameFortschritt ++;

						Destroy (this.gameObject);
				}

				if (gameObject.name == "Baeume") {
					
					healthCount --;
					d.destroyMe (); // Zerstoere Aexte nach einmaligem Gebrauch
					// Play Wood Chop Sound
					if (healthCount == 0) {

						GameObject.Find("Logs").transform.position = objPos;

						Destroy (this.gameObject);
					
					}
				}

							if (gameObject.name == "Logs") {

								

									GameObject.Find("Fire").transform.position = objPos;
									fireBuild = true;
									gameFortschritt ++;

									Destroy (this.gameObject);

								
							}


				if (gameObject.name == "Schwein") {

					// Grunz Sound


					GameObject.Find("FleischRoh").transform.position = objPos;

					Destroy (this.gameObject);
					// Rohes Fleisch
				}

						if (gameObject.name == "FleischRoh") {

							// Brutzel Sound


							GameObject.Find("FleischGar").transform.position = objPos;
							// Spielfortschritt
							meatDone = true;
							gameFortschritt ++;

							Destroy (this.gameObject);

						}

				if (gameObject.name == "Weizen") {

					// Ernte Sound

					Destroy (this.gameObject);

					if (d.name == "Stein") {
						// TODO Mehl hinzufuegen
						GameObject.Find ("Mehl").transform.position = objPos;
					}
					// TODO WeizenKoerner hinzufuegen
					else if (d.name == "Sichel") {
						GameObject.Find ("WeizenKoerner").transform.position = objPos;
					}

					Destroy (this.gameObject);

				}

							if (gameObject.name == "WeizenKoerner") {

								Destroy (this.gameObject);
								if (d.name == "Stein") {
									// TODO Mehl hinzufuegen
									GameObject.Find ("Mehl").transform.position = objPos;
								}
							
							}

				d.parentToReturnTo = this.transform;
			}

		}
			
	}



	public void OnPointerExit (PointerEventData eventData) {

		if (eventData.eligibleForClick) {
			//Debug.Log ("OnPointerExit to " + gameObject.name);
		}
		
		
	}
		
}
