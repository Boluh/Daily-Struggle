using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    [SerializeField]
    private InputField field = null;

    [SerializeField]
    private Slider slider = null;

    [SerializeField]
    private string busPath = "";

    private FMOD.Studio.Bus bus;

    private void Start()
    {
        if(busPath != "")
        {
            bus = RuntimeManager.GetBus(busPath);
        }

 
        bus.getVolume(out float volume);
        slider.value = volume * slider.maxValue;

        UpdateSliderOutput();
    }

    public void UpdateSliderOutput()
    {
        bus.setVolume(slider.value / slider.maxValue);
    }
}
