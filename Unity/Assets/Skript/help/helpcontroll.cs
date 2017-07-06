using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpcontroll : MonoBehaviour {

    public static int counter = 0;

    public GameObject bild1;
    public GameObject bild2;
    public GameObject bild3;
    public GameObject bild4;
    public GameObject bild5;

    public GameObject finish;

    public GameObject buttonr;
    public GameObject buttonl;

    public void push ()
    {
        if (counter == 0)
        {
            buttonl.SetActive(true);
            bild1.SetActive(false);
            bild2.SetActive(true);
        }

        if (counter == 1)
        {
            bild2.SetActive(false);
            bild3.SetActive(true);
        }

        if (counter == 2)
        {
            bild3.SetActive(false);
            bild4.SetActive(true);
        }

        if (counter == 3)
        {
            bild4.SetActive(false);
            bild5.SetActive(true);
            finish.SetActive(true);
            buttonr.SetActive(false);
        }
        counter++;

        if (counter == 4)
        {
            counter--;
        }
    }

    public void back ()
    {
        if (counter == 0)
        {
            bild1.SetActive(true);
            bild2.SetActive(false);
            buttonl.SetActive(false);
        }

        if (counter == 1)
        {
            bild2.SetActive(true);
            bild3.SetActive(false);
        }

        if (counter == 2)
        {
            bild3.SetActive(true);
            bild4.SetActive(false);
        }

        if (counter == 3)
        {
            bild4.SetActive(true);
            bild5.SetActive(false);
            finish.SetActive(false);
            buttonr.SetActive(true);
        }
        counter--;

        if (counter == -1)
        {
            counter++;
        }
    }
}
