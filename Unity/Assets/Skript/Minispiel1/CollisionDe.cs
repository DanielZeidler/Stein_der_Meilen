using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDe : MonoBehaviour {

    public GameObject Ziel;
    private Minispiel1Controller miniCon;

    private void Awake()
    {
        this.miniCon = GameObject.Find("Main Camera").GetComponent<Minispiel1Controller>();
    }
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
            miniCon.setCounter(Minispiel1Controller.Counter.BAUM, miniCon.getCounter(Minispiel1Controller.Counter.BAUM) + 1);
        }else if (sceneObj.name == "stein")
        {
            miniCon.setCounter(Minispiel1Controller.Counter.STEIN, miniCon.getCounter(Minispiel1Controller.Counter.STEIN) + 1);
        }
        else if (sceneObj.name == "schaf")
        {
            miniCon.setCounter(Minispiel1Controller.Counter.TIER, miniCon.getCounter(Minispiel1Controller.Counter.TIER) + 1);
        }
        else if (sceneObj.name == "weizen")
        {
            miniCon.setCounter(Minispiel1Controller.Counter.GETREIDE, miniCon.getCounter(Minispiel1Controller.Counter.GETREIDE) + 1);
        }
    }

    private IEnumerator ToggleSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 1.01f, gameObject.transform.localScale.y * 1.01f, gameObject.transform.localScale.z * 1.01f);
        yield return new WaitForSeconds(0.3f);
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 0.99f, gameObject.transform.localScale.y * 0.99f, gameObject.transform.localScale.z * 0.99f);
    }
}
