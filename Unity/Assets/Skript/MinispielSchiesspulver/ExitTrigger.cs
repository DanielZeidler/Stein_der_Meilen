using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour {

    private SchiesspulverController sC;
    private void Awake()
    {
        sC = GameObject.Find("SchiesspulverWrapper").GetComponent<SchiesspulverController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ColliderWrapper")
        {
            sC.finishTrigger = true;
        }
    }
}
