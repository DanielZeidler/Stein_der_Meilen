using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterMuehle : MonoBehaviour {


	private int count = 0;
	public GameObject finish;
	public GameObject wintext;
	public GameObject aufgabe;


	public void addCount() {
		count += 1;
		print ("richtig, counter +1");
	}
	public int getCount(){
		return count;
	}

	public bool won() {
		if (count == 8) {
			finish.SetActive (true);
			aufgabe.SetActive (false);
			wintext.SetActive (true);

            GameManager.Instance.finishMinispiel6 = true;

            return true;
		} else {
			return false;
		}
	}
}
