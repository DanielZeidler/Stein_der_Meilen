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

	public enum Passend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, WASSER, NONE}; // ENUM fuer Werkzeuge die gehen
	public Passend destroy = Passend.NONE; // InitialWerkzeug

	public enum AuchPassend	{AXT, STEIN, DOLCH, SICHEL, SCHABER, FEUERFAKEL, FEUERSTEIN, BACKGROUND, WASSER, NONE}; // Weitere Werkzeuge die gehen
	public AuchPassend tooDestroy = AuchPassend.NONE; // Initital Alternativ Werkzeug

	MeinTimer myTime = new MeinTimer ();
	Fortschritt fortschritt = Fortschritt.Instance;

	public void Update () {
		
		if (fortschritt.getBrotDone() || fortschritt.getWolle() || fortschritt.getFireBuild() || fortschritt.getMeatDone()) {
			print ("all done");
			GameObject.Find ("Canvas").transform.FindChild ("ErfolgreichBeendet").gameObject.SetActive (true);
		}
	}

	public void OnPointerEnter (PointerEventData eventData) {
		//Debug.Log ("OnPointerEnter to " + gameObject.name);

	}


	public void OnDrop (PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dragged to " + gameObject.name);

		// Check ob Spiel bestanden & weiter



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
						fortschritt.setWolle(true);
						fortschritt.setGameFortschritt (1);

					GameObject.Find ("Hilfstexte").transform.FindChild ("HilfeBaeume").gameObject.SetActive (true);

						
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
					if (!fortschritt.getFireBuild ()) {
						print ("fire not Build");
					}
									fortschritt.setFireBuild (true);
					if (fortschritt.getFireBuild ()) {
						print ("fire Build");
					}
									fortschritt.setGameFortschritt (1);
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
							fortschritt.setMeatDone(true);
							fortschritt.setGameFortschritt (1);
							myTime.setTimer (0f); // resettet Timer
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
												GameObject.Find ("Teig").transform.position = objPos;
												Destroy (this.gameObject);
										}
													if (gameObject.name == "Mehl") {
															GameObject.Find ("Teig").transform.position = objPos;
															Destroy (this.gameObject);
													}
																if (gameObject.name == "Teig") {
																	GameObject.Find ("Brot").transform.position = objPos;
																	fortschritt.setBrotDone (true);
																	fortschritt.setGameFortschritt (1);
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
