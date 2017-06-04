using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAnimationController : MonoBehaviour
{
    private Dictionary<string, SpriteRenderer[]> animWrapperMap;

    private void Awake()
    {
        animWrapperMap = new Dictionary<string, SpriteRenderer[]>();
    }
    // Use this for initialization
    void Start()
    {
        List<SpriteRenderer> tmp = new List<SpriteRenderer>();

        //ErdeAnimWrapper kann später entfernt werden
        foreach (SpriteRenderer spRen in GameObject.Find("ErdeAnimWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("ErdeAnimWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("fliehenderMenschWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("fliehenderMenschWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("jagenderMenschWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("jagenderMenschWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("isstRohesFleischWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("isstRohesFleischWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("menschMitFeuerWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("menschMitFeuerWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("menschKisteWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("menschKisteWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("wagenWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("wagenWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

        foreach (SpriteRenderer spRen in GameObject.Find("menschSteintafelWrapper").GetComponentsInChildren<SpriteRenderer>()) tmp.Add(spRen);
        animWrapperMap.Add("menschSteintafelWrapper", tmp.ToArray());
        tmp = new List<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (StoryContainer.actTextbaustein == 1)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["fliehenderMenschWrapper"]) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 2)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["jagenderMenschWrapper"]) spRen.enabled = true;
            foreach (SpriteRenderer spRen in animWrapperMap["isstRohesFleischWrapper"]) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 3)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["menschMitFeuerWrapper"]) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 4)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["menschKisteWrapper"]) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 5)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["wagenWrapper"]) spRen.enabled = true;
        }
        else if (StoryContainer.actTextbaustein == 6)
        {
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
            StoryContainer.Instance.rotationEarth = true;
            foreach (SpriteRenderer spRen in animWrapperMap["menschSteintafelWrapper"]) spRen.enabled = true;
        }
        else
        {
            StoryContainer.Instance.rotationEarth = false;
            foreach (SpriteRenderer spRen in animWrapperMap["ErdeAnimWrapper"]) spRen.enabled = false;
        }
    }
}
