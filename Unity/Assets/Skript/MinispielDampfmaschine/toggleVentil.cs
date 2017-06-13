using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleVentil : MonoBehaviour {

    private DampfmaschineGameController gC;

    private void Start()
    {
        gC = GameObject.Find("Main Camera").GetComponent<DampfmaschineGameController>();
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "ventilObenEin") gC.toggleVentil(DampfmaschineGameController.Ventil.VENTIL_OBEN_EIN);
        if (gameObject.name == "ventilUntenEin") gC.toggleVentil(DampfmaschineGameController.Ventil.VENTIL_UNTEN_EIN);
        if (gameObject.name == "ventilObenAus") gC.toggleVentil(DampfmaschineGameController.Ventil.VENTIL_OBEN_AUS);
        if (gameObject.name == "ventilUntenAus") gC.toggleVentil(DampfmaschineGameController.Ventil.VENTIL_UNTEN_AUS);
    }
  
}
