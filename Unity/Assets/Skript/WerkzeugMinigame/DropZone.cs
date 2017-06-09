using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {


	// TODO
	/*
	 * Hilfen nach Timer implementieren
	 * 
	 * Texte fuer Hilfe machen
	 * 
	 * Button zum weitermachen erstellen
	 * 
	 */

	//MeinTimer timer = new MeinTimer ();

	public int healthCount = 2; // Lebenspunkte fuer Baeume
	private float zeitschranke = 30f;
	public int gameFortschritt = 0; // Spielfortschritt
	public bool meatDone = false;
	public bool fireBuild = false;
	public bool wolle = false;
	public bool brotDone = false;

	public enum Passend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, WASSER, NONE}; // ENUM fuer Werkzeuge die gehen
	public Passend destroy = Passend.NONE; // InitialWerkzeug

	public enum AuchPassend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, WASSER, NONE}; // Weitere Werkzeuge die gehen
	public AuchPassend tooDestroy = AuchPassend.NONE; // Initital Alternativ Werkzeug

	MeinTimer myTime = new MeinTimer ();

	public void Update () {
		
		print (MeinTimer.timer);
	}

	public void OnPointerEnter (PointerEventData eventData) {
		//Debug.Log ("OnPointerEnter to " + gameObject.name);

	}


	public void OnDrop (PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dragged to " + gameObject.name);

		// Check ob Spiel bestanden & weiter


		if (meatDone && fireBuild && wolle && brotDone) {
			// Spiel geschafft, weiter gehts
		}

		// Hilfen nach Zeit einblenden

		if (myTime.getTimer() > zeitschranke) {

			//switch cases

		}

	

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
						myTime.setTimer (0f); // resettet Timer

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
									myTime.setTimer (0f); // resettet Timer

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
							print (MeinTimer.timer);
							myTime.setTimer (0f); // resettet Timer
					//

							Destroy (this.gameObject);

						}

				if (gameObject.name == "Weizen") {
						GameObject.Find ("WeizenKoerner").transform.position = objPos;
						Destroy (this.gameObject);

				}
							if (gameObject.name == "WeizenKoerner") {
									GameObject.Find ("Mehl").transform.position = objPos;
									Destroy (this.gameObject);
								}
							
										if (gameObject.name == "Mehl") {
												GameObject.Find ("Brotteig").transform.position = objPos;
												Destroy (this.gameObject);
										}
													if (gameObject.name == "Mehl") {
															GameObject.Find ("Brotteig").transform.position = objPos;
															Destroy (this.gameObject);
													}
																if (gameObject.name == "Brotteig") {
																	GameObject.Find ("Brot").transform.position = objPos;
																	brotDone = true;
																	gameFortschritt++;
																	myTime.setTimer (0f); // resettet Timer
																	Destroy (this.gameObject);
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
