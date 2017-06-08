using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour {

    public GameObject cloud;
    private Vector3 start;
    public float speed;

	// Use this for initialization
	void Start () {
        start = cloud.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        cloud.transform.Translate(Vector3.right * speed);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "background")
        {
            cloud.transform.position = start;
        }
        
    }
}
