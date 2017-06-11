using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minispiel1Controller : MonoBehaviour {

    private bool finished = false;

    private bool tier = false;
    private bool stein = false;
    private bool getreide = false;
    private bool baum = false;

    public static int counterTier = 0;
    public static int counterStein = 0;
    public static int counterGetreide = 0;
    public static int counterBaum = 0;


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
    private void Awake()
    {
        
    }

    private void Start()
    {
        firework = GameObject.Find("Fireworks").GetComponent<ParticleSystem>();
        BaumSprite = GameObject.Find("baum").GetComponent<SpriteRenderer>();
        TierSprite = GameObject.Find("schaf").GetComponent<SpriteRenderer>(); 
        SteinSprite = GameObject.Find("stein").GetComponent<SpriteRenderer>(); 
        GetreideSprite = GameObject.Find("weizen").GetComponent<SpriteRenderer>();

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
            if (StoryContainer.accessStoryPart < 2)
            {
                StoryContainer.accessStoryPart = 2;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
    }
}
