using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class editCosts : MonoBehaviour
{



    void Update()
    {
        
    }
private float Radomness = 1;
private float kosten;

public Text liebe;
public Text hass;
public Text gier;
public Text neid;
public Text pazi;
public Text wissen;
    
public float x;
private float checkBereich;
public Resources getNumbers;
public void takeZuneigung(){


kosten = 10 * Random.Range(x,Radomness);
getNumbers.Zuneigung = getNumbers.Zuneigung - kosten; 

}
public void giveZuneigung(){
getNumbers.Zuneigung = getNumbers.Zuneigung + kosten; 
}
public void giveGeld(){
getNumbers.Geld = getNumbers.Geld + kosten; 
}
public void takeGeld(){

getNumbers.Geld = getNumbers.Geld - kosten; 

}
public void giveStaerke(){

checkBereich = PlayerPrefs.GetFloat("LiebeY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kosten = 10 * Random.Range(x,Radomness);
getNumbers.Stärke = getNumbers.Stärke + kosten; 

}
public void takeStaerke(){

checkBereich = PlayerPrefs.GetFloat("LiebeY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kosten = 10 * Random.Range(x,Radomness);
getNumbers.Stärke = getNumbers.Stärke - kosten; 

}
    void Start()
    {
checkBereich = PlayerPrefs.GetFloat("LiebeY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kosten = 10 * Random.Range(x,Radomness);
liebe.text = kosten.ToString();

checkBereich = PlayerPrefs.GetFloat("HassY");
if (checkBereich >= 3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich + x;
}
kosten = 10 * Random.Range(x,Radomness);
hass.text = kosten.ToString();

checkBereich = PlayerPrefs.GetFloat("GierY");
if (checkBereich >= 3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich + x;
}
kosten = 10 * Random.Range(x,Radomness);
gier.text = kosten.ToString();


}

}
