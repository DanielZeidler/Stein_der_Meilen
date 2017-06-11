﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDe : MonoBehaviour {

    public GameObject Ziel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Ziel.name.Equals(collision.gameObject.name))
        {
            StartCoroutine(ToggleSize());
            interact(gameObject, collision.gameObject);
        }
    }

    private void interact(GameObject sceneObj, GameObject collisionObj)
    {
        if (sceneObj.name == "baum")
        {
            Minispiel1Controller.counterBaum++;
        }else if (sceneObj.name == "stein")
        {
            Minispiel1Controller.counterStein++;
        }
        else if (sceneObj.name == "schaf")
        {
            Minispiel1Controller.counterTier++;
        }
        else if (sceneObj.name == "weizen")
        {
            Minispiel1Controller.counterGetreide++;
        }
    }

    private IEnumerator ToggleSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 1.01f, gameObject.transform.localScale.y * 1.01f, gameObject.transform.localScale.z * 1.01f);
        yield return new WaitForSeconds(0.3f);
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 0.99f, gameObject.transform.localScale.y * 0.99f, gameObject.transform.localScale.z * 0.99f);
    }
}
