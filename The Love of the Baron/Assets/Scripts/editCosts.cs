using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class editCosts : MonoBehaviour
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


private float Radomness = 1;
private float kostenliebe;
private float kostenhass;
private float kostengier;
private float kostenneid;
private float kostenpazi;
private float kostenwissen;
private float einnameliebe;
private float einnamehass;
private float einnamegier;
private float einnameneid;
private float einnamepazi;
private float einnamewissen;

public Text kosliebe;
public Text einliebe1;
public Text einliebe2;

public Text koshass;
public Text einhass1;
public Text einhass2;
public Text kosgier;
public Text eingier1;
public Text eingier2;
public Text kosneid;
public Text einneid1;
public Text einneid2;
public Text kospazi;
public Text einpazi1;
public Text einpazi2;
public Text koswissen;
public Text einwissen1;
public Text einwissen2;

    
public float x;
private float checkBereich;
 private void Awake()
{ 
    Geld = PlayerPrefs.GetFloat("Geld");
    Zuneigung=PlayerPrefs.GetFloat("Zuneigung");
    Stärke=PlayerPrefs.GetFloat("Stärke");


checkBereich = PlayerPrefs.GetFloat("LiebeY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostenliebe = 10 * Random.Range(x,Radomness);
einnameliebe = 10 * Random.Range(x,Radomness);
kostenliebe = Mathf.Round(kostenliebe);
einnameliebe = Mathf.Round(einnameliebe)/2;
kosliebe.text = "+"+kostenliebe.ToString();
einliebe1.text = "-"+einnameliebe.ToString();
einliebe2.text = "-"+einnameliebe.ToString();

checkBereich = PlayerPrefs.GetFloat("HassX");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostenhass = 10 * Random.Range(x,Radomness);
einnamehass = 10 * Random.Range(x,Radomness);
kostenhass = Mathf.Round(kostenhass);
einnamehass = Mathf.Round(einnamehass)/2;
koshass.text = "-"+kostenhass.ToString();
einhass1.text = "+" + einnamehass.ToString();
einhass2.text = "+" + einnamehass.ToString();

checkBereich = PlayerPrefs.GetFloat("GierY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostengier = 10 * Random.Range(x,Radomness);
einnamegier = 10 * Random.Range(x,Radomness);
kostengier = Mathf.Round(kostengier);
einnamegier = Mathf.Round(einnamegier)/2;
kosgier.text = "+"+kostengier.ToString();
eingier1.text = "-"+einnamegier.ToString();
eingier2.text = "-"+einnamegier.ToString();

checkBereich = PlayerPrefs.GetFloat("NeidY");
if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostenneid = 10 * Random.Range(x,Radomness);
einnameneid = 10 * Random.Range(x,Radomness);
kostenneid = Mathf.Round(kostenneid);
einnameneid = Mathf.Round(einnameneid)/2;
kosneid.text = "-"+kostenneid.ToString();
einneid1.text = "+"+einnameneid.ToString();
einneid2.text = "+"+einnameneid.ToString();

checkBereich = PlayerPrefs.GetFloat("PaziX");

if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostenpazi = 10 * Random.Range(x,Radomness);
einnamepazi = 10 * Random.Range(x,Radomness);
kostenpazi = Mathf.Round(kostenpazi);
einnamepazi = Mathf.Round(einnamepazi)/2;
kospazi.text = "+"+kostenpazi.ToString();
einpazi1.text = "-"+einnamepazi.ToString();
einpazi2.text = "-"+einnamepazi.ToString();

checkBereich = PlayerPrefs.GetFloat("WissenY");

if (checkBereich >= -3.1)
{
    Radomness = Radomness - x;
    checkBereich = checkBereich - x;
}
kostenwissen = 10 * Random.Range(x,Radomness);
einnamewissen = 10 * Random.Range(x,Radomness);
kostenwissen = Mathf.Round(kostenwissen);
einnamewissen = Mathf.Round(einnamewissen)/2;
koswissen.text = "-"+kostenwissen.ToString();
einwissen1.text = "+"+einnamewissen.ToString();
einwissen2.text = "+"+einnamewissen.ToString();

}

public void takeZuneigung(){
Zuneigung = Zuneigung - kostenneid; 
Geld = Geld + einnameneid;
Stärke = Stärke + einnameneid; 
}
public void giveZuneigung(){
Zuneigung = Zuneigung + kostenliebe; 
Geld = Geld - einnameliebe;
Stärke = Stärke - einnameliebe; 
}
public void giveGeld(){
Geld = Geld + kostengier; 
Stärke = Stärke - einnamegier;
Zuneigung = Zuneigung - einnamegier;
}
public void takeGeld(){
Geld = Geld - kostenwissen; 
Stärke = Stärke + einnamewissen;
Zuneigung = Zuneigung + einnamewissen;
}
public void giveStaerke(){
Stärke = Stärke + kostenpazi;
Geld = Geld - einnamepazi; 
Zuneigung = Zuneigung - einnamepazi; 
}
public void takeStaerke(){
Stärke = Stärke - kostenhass;
Geld = Geld + einnamehass;
Zuneigung = Zuneigung + einnamehass; 
}
private void Start() {
    
}
    void Update()
    { 
    money = Geld.ToString();
   AusgabeGeld.text = money;
   likehood = Zuneigung.ToString();
   AusgabeZuneigung.text = likehood;
   strength = Stärke.ToString();
   AusgabeStärke.text = strength;

if (Geld <= 0.1f && Zuneigung <= 0.1f && Stärke <= 0.1f)
{
    SceneManager.LoadScene("DeathScreen", LoadSceneMode.Single);  
}
    }


private void OnDestroy() {
    PlayerPrefs.SetFloat("Geld",Geld);
    PlayerPrefs.SetFloat("Zuneigung",Zuneigung);
    PlayerPrefs.SetFloat("Stärke",Stärke);
}




}
