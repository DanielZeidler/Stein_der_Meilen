using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparancy : MonoBehaviour {

    [Range(0, 1)] public float opacity;

    private Renderer rend;
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, opacity);
    }

    private void Update()
    {
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, opacity);
    }
}
