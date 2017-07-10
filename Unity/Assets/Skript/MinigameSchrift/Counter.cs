using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
		

	private int count = 0;
	public GameObject wonText;
	public GameObject finish;

	public void addCount() {
		count += 1;
	}
	public int getCount(){
		return count;
	}

	public bool won() {
		if (count == 6) {
			wonText.SetActive (true);
			finish.SetActive (true);
			return true;
		} else {
			return false;
		}
	}
}
