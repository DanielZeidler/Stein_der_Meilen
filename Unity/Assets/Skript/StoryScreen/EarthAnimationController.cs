using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAnimationController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StoryContainer.actTextbaustein == 1)
        {
            foreach (SpriteRenderer spRen in GameObject.Find("ErdeAnimWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in GameObject.Find("fliehenderMenschWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 2)
        {
            foreach (SpriteRenderer spRen in GameObject.Find("ErdeAnimWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in GameObject.Find("jagenderMenschWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = true;
            foreach (SpriteRenderer spRen in GameObject.Find("isstRohesFleischWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 3)
        {
            foreach (SpriteRenderer spRen in GameObject.Find("ErdeAnimWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in GameObject.Find("menschMitFeuerWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = true;
        }
        else
        {
            StoryContainer.Instance.rotationEarth = false;
            foreach (SpriteRenderer spRen in GameObject.Find("ErdeAnimWrapper").GetComponentsInChildren<SpriteRenderer>()) spRen.enabled = false;
        }
    }
}
