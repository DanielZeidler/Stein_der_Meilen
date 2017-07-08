using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minispiel1Controller : MonoBehaviour {

    private bool finished = false;

    private bool tier = false;
    private bool stein = false;
    private bool getreide = false;
    private bool baum = false;

    public int counterTier = 0;
    public int counterStein = 0;
    public int counterGetreide = 0;
    public int counterBaum = 0;


    public Sprite defaultBaum;
    public Sprite defaultTier;
    public Sprite defaultStein;
    public Sprite defaultWeizen;

    public Sprite newBaum;
    public Sprite newTier;
    public Sprite newStein;
    public Sprite newWeizen;

    private SpriteRenderer BaumSprite;
    private SpriteRenderer TierSprite;
    private SpriteRenderer SteinSprite;
    private SpriteRenderer GetreideSprite;

    private ParticleSystem firework;
    private Text storyText;

    private void Start()
    {
        firework = GameObject.Find("Fireworks").GetComponent<ParticleSystem>();
        BaumSprite = GameObject.Find("baum").GetComponent<SpriteRenderer>();
        TierSprite = GameObject.Find("schaf").GetComponent<SpriteRenderer>(); 
        SteinSprite = GameObject.Find("stein").GetComponent<SpriteRenderer>(); 
        GetreideSprite = GameObject.Find("weizen").GetComponent<SpriteRenderer>();

        storyText = GameObject.Find("HintText").GetComponent<Text>();

        BaumSprite.sprite = defaultBaum;
        TierSprite.sprite = defaultTier;
        SteinSprite.sprite = defaultStein;
        GetreideSprite.sprite = defaultWeizen;
    }

    private void Update()
    {
        if (counterTier > 5)
        {
            TierSprite.sprite = newTier;
            tier = true;
        }
        if (counterBaum > 5)
        {
            BaumSprite.sprite = newBaum;
            baum = true;
        }
        if (counterStein > 5)
        {
            SteinSprite.sprite = newStein;
            stein = true;
        }
        if (counterGetreide > 5)
        {
            GetreideSprite.sprite = newWeizen;
            getreide = true;
        }

        if (tier && baum && getreide && stein && !finished)
        {
            firework.Play();
            finished = true;
            storyText.text = "Gewonnen! Du kannst nun mit der Story weiter machen.";
            GameManager.Instance.finishMinispiel0 = true;
            
        }
    }
    public enum Counter { TIER, BAUM, STEIN, GETREIDE };

    public int getCounter(Counter c)
    {
        if(c == Counter.BAUM)
        {
            return this.counterBaum;
        }else if(c == Counter.GETREIDE)
        {
            return this.counterGetreide;
        }else if(c == Counter.STEIN)
        {
            return this.counterStein;
        }else if(c == Counter.TIER)
        {
            return this.counterTier;
        }else return 0;
    }
    public void setCounter(Counter c,int value)
    {
        if (c == Counter.BAUM)
        {
            this.counterBaum = value;
        }
        else if (c == Counter.GETREIDE)
        {
            this.counterGetreide = value;
        }
        else if (c == Counter.STEIN)
        {
            this.counterStein = value;
        }
        else if (c == Counter.TIER)
        {
            this.counterTier = value;
        }
    }

}
