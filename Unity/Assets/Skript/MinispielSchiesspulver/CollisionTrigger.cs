using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

    private Vector3 initPosition;
    private draganddrop flareDraganddrop;
    private GameObject flareObj;

    private void Start()
    {
        flareObj = GameObject.Find("Flare");
        flareDraganddrop = flareObj.GetComponent<draganddrop>();
        initPosition = flareObj.GetComponent<Transform>().position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ColliderWrapper")
        {
            flareDraganddrop.drag = false;
            flareObj.GetComponent<Transform>().position = new Vector3(initPosition.x,initPosition.y,initPosition.z);
        }
    }
}
