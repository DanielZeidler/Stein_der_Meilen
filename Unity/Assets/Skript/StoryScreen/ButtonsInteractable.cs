using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsInteractable : MonoBehaviour
{
    public void disableButtonsInteractableInGameobject(GameObject gameObject)
    {
        foreach (Button button in gameObject.GetComponents<Button>()) GameManager.Instance.setErfindungButtonInteractable(button.name, false);
    }
    public void disableButtonsInteractableInGameobjectChildrens(GameObject gameObject)
    {
        foreach (Button button in gameObject.GetComponentsInChildren<Button>()) GameManager.Instance.setErfindungButtonInteractable(button.name, false);
    }
    public void enableButtonsInteractableInGameobject(GameObject gameObject)
    {
        foreach (Button button in gameObject.GetComponents<Button>()) GameManager.Instance.setErfindungButtonInteractable(button.name, true);
    }
    public void enableButtonsInteractableInGameobjectChildrens(GameObject gameObject)
    {
        foreach (Button button in gameObject.GetComponentsInChildren<Button>()) GameManager.Instance.setErfindungButtonInteractable(button.name, true);
    }
    public void enableButton(string name)
    {
        GameManager.Instance.setErfindungButtonInteractable(name, true);
    }
    public void enableButton(Button button)
    {
        GameManager.Instance.setErfindungButtonInteractable(button.name, true);
    }
    public void disbleButton(string name)
    {
        GameManager.Instance.setErfindungButtonInteractable(name, false);
    }
    public void disbleButton(Button button)
    {
        GameManager.Instance.setErfindungButtonInteractable(button.name, false);
    }


}
