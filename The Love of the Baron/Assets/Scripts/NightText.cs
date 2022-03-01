using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class NightText : MonoBehaviour
{
public Text text;

private float Geld;
private float Zuneigung;
private float Stärke;

private void Awake() {

Geld =PlayerPrefs.GetFloat("Geld") - PlayerPrefs.GetFloat("StartGeld");  
Zuneigung = PlayerPrefs.GetFloat("Zuneigung") - PlayerPrefs.GetFloat("StartZuneigung");
Stärke = PlayerPrefs.GetFloat("Stärke") - PlayerPrefs.GetFloat("StartStärke");
    text.text = "Das sind die Einnahmen und Ausgaben von heute:" + " \n" + "  "+ Geld.ToString() + " " + "in Gold \n" + "  " + Zuneigung.ToString() + " " + "in Zuneigung \n" + "  "+ Stärke.ToString() + " " + "in Stärke \n";
}

}
