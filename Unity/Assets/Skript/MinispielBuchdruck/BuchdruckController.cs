using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuchdruckController : MonoBehaviour {

    public bool boolletter1;
    public bool boolletter2;
    public bool boolletter3;
    public bool boolletter4;
    public bool boolletter5;
    public bool boolletter6;
    public bool boolletter7;
    public bool boolletter8;
    public bool boolletter9;
    public bool boolletter10;
    public bool boolletter11;
    public bool boolletter12;
    public bool boolletter13;
    public bool boolletter14;
    public bool boolletter15;
    public bool boolletter16;

    private draganddrop[] ddArray;
    private ParticleSystem firework;
    private bool finish;

    private Animator animator;

    private void Awake()
    {
        animator = GameObject.Find("SzeneObjectWrapper").GetComponent<Animator>();
        ddArray = new draganddrop[15];
        ddArray = GameObject.Find("LettersWrapper").GetComponentsInChildren<draganddrop>();
    }
    // Use this for initialization
    void Start () {
        firework = GameObject.Find("Fireworks").GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
       if(!finish && boolletter1 && boolletter2 && boolletter3 && boolletter4 && boolletter5 && boolletter6 && boolletter7 && boolletter8 && boolletter9 && boolletter10 && boolletter11 && boolletter12 && boolletter13 && boolletter14 && boolletter15 && boolletter16)
        {

            StartCoroutine(FinishAnimation());
        }
    }

    private IEnumerator FinishAnimation()
    {

        yield return new WaitForSeconds(1f);

        foreach (draganddrop dd in ddArray)
        {
            dd.drag = false;
        }
        animator.SetBool("finish", true);
        firework.Play();
        finish = true;
        animator.SetBool("finish", true);
        GameManager.Instance.finishMinispiel7 = true;
        
    }
}
