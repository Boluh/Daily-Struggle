using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Resources : MonoBehaviour
{
    public int Geld;
    public int Zuneigung;
    public int Stärke;

    public Text AusgabeGeld;
    public Text AusgabeZuneigung;
    public Text AusgabeStärke;

    private string money;
    private string likehood;
    private string strength;
    // Update is called once per frame
    void Update()
    { 
    money = Geld.ToString();
   AusgabeGeld.text = money;
   likehood = Zuneigung.ToString();
   AusgabeZuneigung.text = likehood;
   strength = Stärke.ToString();
   AusgabeStärke.text = strength;

    }
}
