﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audiochange : MonoBehaviour {

    public Slider mySlider;

    public void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }
}