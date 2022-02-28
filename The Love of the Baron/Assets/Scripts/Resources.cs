using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Resources : MonoBehaviour
{
    public float Geld;
    public float Zuneigung;
    public float Stärke;

    public Text AusgabeGeld;
    public Text AusgabeZuneigung;
    public Text AusgabeStärke;

    private string money;
    private string likehood;
    private string strength;


    void Update()
    { 
    money = Geld.ToString();
   AusgabeGeld.text = money;
   likehood = Zuneigung.ToString();
   AusgabeZuneigung.text = likehood;
   strength = Stärke.ToString();
   AusgabeStärke.text = strength;

if (Geld == 0 && Zuneigung == 0 && Stärke == 0)
{
    SceneManager.LoadScene("DeathScreen", LoadSceneMode.Single);  
}
    } 
    internal static T Load<T>(string v)
    {
        throw new NotImplementedException();
    }

    internal static Font Load(string v, Type type)
    {
        throw new NotImplementedException();
    }




}
