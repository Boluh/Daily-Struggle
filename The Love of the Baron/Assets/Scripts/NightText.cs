using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class NightText : MonoBehaviour
{
public Text text;
[SerializeField] public int dayCount;

private float Geld;
private float Zuneigung;
private float Stärke;

private void Awake() {
    string recallText = Application.dataPath + "/TextAssets/" + "Endetag"+ dayCount.ToString() + ".txt";
    List<string> fileLines = File.ReadAllLines(recallText).ToList();

Geld =PlayerPrefs.GetFloat("Geld") - PlayerPrefs.GetFloat("StartGeld");  
Zuneigung = PlayerPrefs.GetFloat("Zuneigung") - PlayerPrefs.GetFloat("StartZuneigung");
Stärke = PlayerPrefs.GetFloat("Stärke") - PlayerPrefs.GetFloat("StartStärke");
text.text = fileLines[0] + "\n" + "Das sind die Einnahmen und Ausgaben von heute:" + " \n" + "  "+ Geld.ToString() + " " + "in Gold \n" + "  " + Zuneigung.ToString() + " " + "in Zuneigung \n" + "  "+ Stärke.ToString() + " " + "in Stärke \n";
}

}
