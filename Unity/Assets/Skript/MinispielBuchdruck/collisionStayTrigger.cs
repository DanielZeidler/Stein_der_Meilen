using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionStayTrigger : MonoBehaviour
{

    private BuchdruckController buchdruckController;
    private bool fixIt;
    private string ownLetter;
    private int count;
    private void Awake()
    {
        buchdruckController = GameObject.Find("Main Camera").GetComponent<BuchdruckController>();
        fixIt = false;
        count = 0;
        ownLetter = gameObject.GetComponent<letterContainer>().letter;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<letterContainer>() != null)
        {
            count += 1;
            string name = gameObject.name;
            string number = name.Replace("ColliderLetter", "");
            int num = Int32.Parse(number);
            
            if (num == 1 && !buchdruckController.boolletter1)
            {
                fixIt = true;
            }
            else if (num == 2 && !buchdruckController.boolletter2)
            {
                fixIt = true;
            }
            else if (num == 3 && !buchdruckController.boolletter3)
            {
                fixIt = true;
            }
            else if (num == 4 && !buchdruckController.boolletter4)
            {
                fixIt = true;
            }
            else if (num == 5 && !buchdruckController.boolletter5)
            {
                fixIt = true;
            }
            else if (num == 6 && !buchdruckController.boolletter6)
            {
                fixIt = true;
            }
            else if (num == 7 && !buchdruckController.boolletter7)
            {
                fixIt = true;
            }
            else if (num == 8 && !buchdruckController.boolletter8)
            {
                fixIt = true;
            }
            else if (num == 9 && !buchdruckController.boolletter9)
            {
                fixIt = true;
            }
            else if (num == 10 && !buchdruckController.boolletter10)
            {
                fixIt = true;
            }
            else if (num == 11 && !buchdruckController.boolletter11)
            {
                fixIt = true;
            }
            else if (num == 12 && !buchdruckController.boolletter12)
            {
                fixIt = true;
            }
            else if (num == 13 && !buchdruckController.boolletter13)
            {
                fixIt = true;
            }
            else if (num == 14 && !buchdruckController.boolletter14)
            {
                fixIt = true;
            }
            else if (num == 15 && !buchdruckController.boolletter15)
            {
                fixIt = true;
            }
            else if (num == 16 && !buchdruckController.boolletter16)
            {
                fixIt = true;
            }
        }
    }

    private void fixPosition(Collider2D collision)
    {
        if (fixIt && count == 1)
        {
            foreach (draganddrop dad in collision.GetComponentsInParent<draganddrop>()) dad.drag = false;
            foreach (draganddrop dad in collision.GetComponentsInChildren<draganddrop>()) dad.drag = false;
            if (collision.name.Substring(0, 15) == "letterContainer")
            {
                collision.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            }

            fixIt = false;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        Debug.Log(count);
        if (collision.GetComponent<letterContainer>() != null)
        {
            Debug.Log("Stay");
            if (ownLetter == collision.GetComponent<letterContainer>().letter && count == 1)
            {
                setBoolLetterState(true);
            }
        }
        fixPosition(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<letterContainer>() != null)
        {
            if (gameObject.GetComponent<letterContainer>().letter == collision.GetComponent<letterContainer>().letter && count == 1)
            {
                setBoolLetterState(false);
            }
            count = count - 1;
        }
    }

    private void setBoolLetterState(bool value)
    {
        string name = gameObject.name;
        string number = name.Replace("ColliderLetter", "");
        int num = Int32.Parse(number);

        switch (num)
        {
            case 1: buchdruckController.boolletter1 = value; break;
            case 2: buchdruckController.boolletter2 = value; break;
            case 3: buchdruckController.boolletter3 = value; break;
            case 4: buchdruckController.boolletter4 = value; break;
            case 5: buchdruckController.boolletter5 = value; break;
            case 6: buchdruckController.boolletter6 = value; break;
            case 7: buchdruckController.boolletter7 = value; break;
            case 8: buchdruckController.boolletter8 = value; break;
            case 9: buchdruckController.boolletter9 = value; break;
            case 10: buchdruckController.boolletter10 = value; break;
            case 11: buchdruckController.boolletter11 = value; break;
            case 12: buchdruckController.boolletter12 = value; break;
            case 13: buchdruckController.boolletter13 = value; break;
            case 14: buchdruckController.boolletter14 = value; break;
            case 15: buchdruckController.boolletter15 = value; break;
            case 16: buchdruckController.boolletter16 = value; break;
            default: break;
        }
    }
    
}
