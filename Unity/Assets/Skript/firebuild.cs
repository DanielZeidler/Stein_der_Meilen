using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebuild : MonoBehaviour {

    public Sprite stone;
    public Sprite branchTexture;
    public Sprite woodTexture;
    public Sprite smallfireTexture;
    public Sprite fireTexture;
    public int count;
    public SpriteRenderer fire;

    // Use this for initialization
    void Start () {
        fire = GetComponent<SpriteRenderer>();
        count = 0;
	}

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Steine" && count == 0)
        {
            fire.sprite = stone;
            DestroyObject(other.gameObject);
            count = 1;
        }

        if (other.tag == "Aeste" && count == 1)
        {
            fire.sprite = branchTexture;
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Holz" && count == 2)
        {
            fire.sprite = woodTexture;
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Feuerstein" && count == 3)
        {
            fire.sprite = smallfireTexture;
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Blatt" && count == 4)
        {
            fire.sprite = fireTexture;
            DestroyObject(other.gameObject);
            count++;
        }
    }
}
