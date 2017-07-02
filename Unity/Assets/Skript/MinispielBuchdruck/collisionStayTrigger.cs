using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionStayTrigger : MonoBehaviour {

    private BuchdruckController buchdruckController;

    private void Awake()
    {
        buchdruckController = GameObject.Find("Main Camera").GetComponent<BuchdruckController>();
    }
    
    void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.GetComponent<letterContainer>().letter == collision.GetComponent<letterContainer>().letter)
        {
            string name = gameObject.name;
            string number = name.Replace("ColliderLetter", "");
            int num = Int32.Parse(number);

            if(num == 1)
            {
                buchdruckController.boolletter1 = true;
            }
            else if(num == 2)
            {
                buchdruckController.boolletter2 = true;
            }
            else if (num == 3)
            {
                buchdruckController.boolletter3 = true;
            }
            else if (num == 4)
            {
                buchdruckController.boolletter4 = true;
            }
            else if (num == 5)
            {
                buchdruckController.boolletter5 = true;
            }
            else if (num == 6)
            {
                buchdruckController.boolletter6 = true;
            }
            else if (num == 7)
            {
                buchdruckController.boolletter7 = true;
            }
            else if (num == 8)
            {
                buchdruckController.boolletter8 = true;
            }
            else if (num == 9)
            {
                buchdruckController.boolletter9 = true;
            }
            else if (num == 10)
            {
                buchdruckController.boolletter10 = true;
            }
            else if (num == 11)
            {
                buchdruckController.boolletter11 = true;
            }
            else if (num == 12)
            {
                buchdruckController.boolletter12 = true;
            }
            else if (num == 13)
            {
                buchdruckController.boolletter13 = true;
            }
            else if (num == 14)
            {
                buchdruckController.boolletter14 = true;
            }
            else if (num == 15)
            {
                buchdruckController.boolletter15 = true;
            }
            else if (num == 16)
            {
                buchdruckController.boolletter16 = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.GetComponent<letterContainer>().letter == collision.GetComponent<letterContainer>().letter)
        {
            string name = gameObject.name;
            string number = name.Replace("ColliderLetter", "");
            int num = Int32.Parse(number);

            if (num == 1)
            {
                buchdruckController.boolletter1 = false;
            }
            else if (num == 2)
            {
                buchdruckController.boolletter2 = false;
            }
            else if (num == 3)
            {
                buchdruckController.boolletter3 = false;
            }
            else if (num == 4)
            {
                buchdruckController.boolletter4 = false;
            }
            else if (num == 5)
            {
                buchdruckController.boolletter5 = false;
            }
            else if (num == 6)
            {
                buchdruckController.boolletter6 = false;
            }
            else if (num == 7)
            {
                buchdruckController.boolletter7 = false;
            }
            else if (num == 8)
            {
                buchdruckController.boolletter8 = false;
            }
            else if (num == 9)
            {
                buchdruckController.boolletter9 = false;
            }
            else if (num == 10)
            {
                buchdruckController.boolletter10 = false;
            }
            else if (num == 11)
            {
                buchdruckController.boolletter11 = false;
            }
            else if (num == 12)
            {
                buchdruckController.boolletter12 = false;
            }
            else if (num == 13)
            {
                buchdruckController.boolletter13 = false;
            }
            else if (num == 14)
            {
                buchdruckController.boolletter14 = false;
            }
            else if (num == 15)
            {
                buchdruckController.boolletter15 = false;
            }
            else if (num == 16)
            {
                buchdruckController.boolletter16 = false;
            }
        }
    }

}
