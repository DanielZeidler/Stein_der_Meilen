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

    public bool ventilObenEin;
    public bool ventilObenAus;
    public bool ventilUntenEin;
    public bool ventilUntenAus;

    public enum Ventil { VENTIL_OBEN_EIN,VENTIL_OBEN_AUS,VENTIL_UNTEN_EIN,VENTIL_UNTEN_AUS};


    private Animator animator;
    private bool trigger1;
    private bool triggerFinish;

    public int counter;
    private ParticleSystem firework;

    private void Awake()
    {
        animator = GameObject.Find("DampfmaschineWrapper").GetComponent<Animator>();

        ventilObenEinSprite = GameObject.Find("ventilObenEin").GetComponent<SpriteRenderer>();
        ventilObenAusSprite = GameObject.Find("ventilObenAus").GetComponent<SpriteRenderer>();
        ventilUntenEinSprite = GameObject.Find("ventilUntenEin").GetComponent<SpriteRenderer>();
        ventilUntenAusSprite = GameObject.Find("ventilUntenAus").GetComponent<SpriteRenderer>();

        ventilObenEin = false;
        ventilObenAus = false; 
        ventilUntenEin = false; 
        ventilUntenAus = false;

        animator.SetBool(0, false);
        animator.SetBool(1, false);
        animator.SetBool(2, false);
        animator.SetBool(3, false);
        
        trigger1 = false;
        triggerFinish = false;

        counter = 0;
    }
    // Use this for initialization
    void Start () {
        firework = GameObject.Find("Fireworks").GetComponent<ParticleSystem>();

        ventilObenEinSprite.sprite = ventilZu;
        ventilObenAusSprite.sprite = ventilZu;
        ventilUntenEinSprite.sprite = ventilZu;
        ventilUntenAusSprite.sprite = ventilZu;
    }
	
	// Update is called once per frame
	void Update () {

        if(animator.GetCurrentAnimatorClipInfoCount(0) == 1)
        {
            trigger1 = true;
        }
        if (animator.GetCurrentAnimatorClipInfoCount(0) == 0 && trigger1)
        {
            trigger1 = false;
            counter++;
        }
        if(!triggerFinish && counter == 2)
        {
            triggerFinish = true;
            firework.Play();
        }
	}

    public void toggleVentil(Ventil ventil)
    {
        if (ventil == Ventil.VENTIL_OBEN_AUS)
        {
            if (ventilObenAusSprite.sprite == ventilZu)
            {
                ventilObenAusSprite.sprite = ventilOffen;
                ventilObenAus = true;
                animator.SetBool("ObenAus", true);
            }
            else
            {
                ventilObenAusSprite.sprite = ventilZu;
                ventilObenAus = false;
                animator.SetBool("ObenAus", false);
            }
        }
        else if (ventil == Ventil.VENTIL_OBEN_EIN)
        {
            if (ventilObenEinSprite.sprite == ventilZu)
            {
                ventilObenEinSprite.sprite = ventilOffen;
                ventilObenEin = true;
                animator.SetBool("ObenEin", true);
            }
            else
            {
                ventilObenEinSprite.sprite = ventilZu;
                ventilObenEin = false;
                animator.SetBool("ObenEin", false);
            }
        }
        else if (ventil == Ventil.VENTIL_UNTEN_AUS)
        {
            if (ventilUntenAusSprite.sprite == ventilZu)
            {
                ventilUntenAusSprite.sprite = ventilOffen;
                ventilUntenAus = true;
                animator.SetBool("UntenAus", true);
            }
            else
            {
                ventilUntenAusSprite.sprite = ventilZu;
                ventilUntenAus = false;
                animator.SetBool("UntenAus", false);
            }
        }
        else if (ventil == Ventil.VENTIL_UNTEN_EIN)
        {
            if (ventilUntenEinSprite.sprite == ventilZu)
            {
                ventilUntenEinSprite.sprite = ventilOffen;
                ventilUntenEin = true;
                animator.SetBool("UntenEin", true);
            }
            else
            {
                ventilUntenEinSprite.sprite = ventilZu;
                ventilUntenEin = false;
                animator.SetBool("UntenEin", false);
            }
        }
    }
}
