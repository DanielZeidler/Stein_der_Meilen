using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firebuild : MonoBehaviour {

    public Sprite stone;
    public Sprite branchTexture;
    public Sprite woodTexture;
    public Sprite smallfireTexture;
    public Sprite fireTexture;
    public int count;
    public SpriteRenderer fire;
    public Text finishtext;
    public Text steintext;
    public Text aestetext;
    public Text holztext;
    public Text feuersteintext;
    public Text blatttext;
    public GameObject finishbutton;
    public GameObject textimage;
    public GameObject lagerfeuer;

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
            DestroyObject(steintext);
            DestroyObject(other.gameObject);
            count = 1;
        }

        if (other.tag == "Aeste" && count == 1)
        {
            fire.sprite = branchTexture;
            DestroyObject(aestetext);
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Holz" && count == 2)
        {
            fire.sprite = woodTexture;
            DestroyObject(holztext);
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Feuerstein" && count == 3)
        {
            fire.sprite = smallfireTexture;
            DestroyObject(feuersteintext);
            DestroyObject(other.gameObject);
            count++;
        }

        if (other.tag == "Blatt" && count == 4)
        {
            fire.sprite = fireTexture;
            DestroyObject(blatttext);
            DestroyObject(other.gameObject);
            DestroyObject(textimage);
            finishtext.enabled = true;
            finishbutton.SetActive(true);
            count++;
        }

        //Textfelder

        if (other.tag != "Steine" && count == 0)
        {
            steintext.enabled = true;
            textimage.SetActive(true);
        }

        if (other.tag != "Aeste" && count == 1)
        {
            aestetext.enabled = true;
            textimage.SetActive(true);
        }

        if (other.tag != "Holz" && count == 2)
        {
            holztext.enabled = true;
            textimage.SetActive(true);
        }

        if (other.tag != "Feuerstein" && count == 3)
        {
            feuersteintext.enabled = true;
            textimage.SetActive(true);
        }

        if (other.tag != "Blatt" && count == 4)
        {
            blatttext.enabled = true;
            textimage.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
   
        //Textfelder

        if (other.tag != "Steine" && count == 0)
        {
            steintext.enabled = false;
            textimage.SetActive(false);
        }

        if (other.tag != "Aeste" && count == 1)
        {
            aestetext.enabled = false;
            textimage.SetActive(false);
        }

        if (other.tag != "Holz" && count == 2)
        {
            holztext.enabled = false;
            textimage.SetActive(false);
        }

        if (other.tag != "Feuerstein" && count == 3)
        {
            feuersteintext.enabled = false;
            textimage.SetActive(false);
        }

        if (other.tag != "Blatt" && count == 4)
        {
            blatttext.enabled = false;
            textimage.SetActive(false);
        }
    }
}
