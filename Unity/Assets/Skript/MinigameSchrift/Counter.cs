using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
		

	private int count = 0;


	public void addCount() {
		count += 1;
	}
	public int getCount(){
		return count;
	}

	public bool won() {
		if (count == 6) {
			return true;
		} else {
			return false;
		}
	}
}
