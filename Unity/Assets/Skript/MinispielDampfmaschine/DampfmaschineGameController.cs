using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampfmaschineGameController : MonoBehaviour {

    public Sprite ventilOffen;
    public Sprite ventilZu;

    public Sprite startDampfmaschine;
    public Sprite runDampfmaschine;

    private SpriteRenderer ventilObenEinSprite;
    private SpriteRenderer ventilObenAusSprite;
    private SpriteRenderer ventilUntenEinSprite;
    private SpriteRenderer ventilUntenAusSprite;

    private bool ventilObenEin;
    private bool ventilObenAus;
    private bool ventilUntenEin;
    private bool ventilUntenAus;

    public enum Ventil { VENTIL_OBEN_EIN,VENTIL_OBEN_AUS,VENTIL_UNTEN_EIN,VENTIL_UNTEN_AUS};

    private void Awake()
    {
        ventilObenEinSprite = GameObject.Find("ventilObenEin").GetComponent<SpriteRenderer>();
        ventilObenAusSprite = GameObject.Find("ventilObenAus").GetComponent<SpriteRenderer>();
        ventilUntenEinSprite = GameObject.Find("ventilUntenEin").GetComponent<SpriteRenderer>();
        ventilUntenAusSprite = GameObject.Find("ventilUntenAus").GetComponent<SpriteRenderer>();
    }
    // Use this for initialization
    void Start () {
        ventilObenEinSprite.sprite = ventilZu;
        ventilObenAusSprite.sprite = ventilZu;
        ventilUntenEinSprite.sprite = ventilZu;
        ventilUntenAusSprite.sprite = ventilZu;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toggleVentil(Ventil ventil)
    {
        if (ventil == Ventil.VENTIL_OBEN_AUS)
        {
            if(ventilObenAusSprite.sprite == ventilZu)
            {
                ventilObenAusSprite.sprite = ventilOffen;
            }else ventilObenAusSprite.sprite = ventilZu;
        }
        else if (ventil == Ventil.VENTIL_OBEN_EIN)
        {
            if(ventilObenEinSprite.sprite == ventilZu)
            {
                ventilObenEinSprite.sprite = ventilOffen;
            }else ventilObenEinSprite.sprite = ventilZu;
        }
        else if (ventil == Ventil.VENTIL_UNTEN_AUS)
        {
            if(ventilUntenAusSprite.sprite == ventilZu)
            {
                ventilUntenAusSprite.sprite = ventilOffen;
            }else ventilUntenAusSprite.sprite = ventilZu;
        }
        else if (ventil == Ventil.VENTIL_UNTEN_EIN)
        {
            if (ventilUntenEinSprite.sprite == ventilZu)
            {
                ventilUntenEinSprite.sprite = ventilOffen;
            }else ventilUntenEinSprite.sprite = ventilZu;
        }
    }
}
