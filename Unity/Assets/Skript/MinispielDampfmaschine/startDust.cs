using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDust : MonoBehaviour {

    public ParticleSystem particleFire;
    public ParticleSystem[] particlesToStart;

    private DampfmaschineGameController gC;

    private void Start()
    {
        gC = GameObject.Find("Main Camera").GetComponent<DampfmaschineGameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "fackel")
        {
            Destroy(collision.gameObject);
            particleFire.Play();
            foreach (ParticleSystem psys in particlesToStart)
            {
                psys.Play();
            }
            StartCoroutine(changeBackgroundImage());
            gC.setHintText();
        }
    }

    private IEnumerator changeBackgroundImage()
    {
        yield return new WaitForSeconds(18);
        GameObject.Find("hintergrund").GetComponent<SpriteRenderer>().sprite = gC.runDampfmaschine;
        foreach (ParticleSystem psys in particlesToStart)
        {
            psys.Stop();
        }
    }
}
