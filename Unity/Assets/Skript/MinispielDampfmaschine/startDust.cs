using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDust : MonoBehaviour {

    public ParticleSystem[] particlesToStart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "fackel")
        {
            Destroy(collision.gameObject);
            foreach(ParticleSystem psys in particlesToStart)
            {
                psys.Play();
            }
        }
    }
}
