using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchiesspulverController : MonoBehaviour {
    
    private ParticleSystem firework;
    public bool finishTrigger;
    private bool finish;

    private void Awake()
    {
        finish = false;
        finishTrigger = false;
    }
    void Start()
    {
        firework = GameObject.Find("Fireworks").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update () {
        if (!finish && finishTrigger)
        {
            firework.Play();
            finish = true;
            GameManager.Instance.finishMinispiel5 = true;
            
        }
    }
}

