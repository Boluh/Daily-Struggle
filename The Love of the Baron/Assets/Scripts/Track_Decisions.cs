using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Track_Decisions : MonoBehaviour
{

   
private Vector3 liebe;
private Vector3 hass;
private Vector3 gier;
private Vector3 neid;
private Vector3 pazifismus;
private Vector3 wissen;


public LineRenderer drawHexagon;


public Vector3 startLiebe;
public Vector3 endLiebe;
public Vector3 startHass;
public Vector3 endHass;
public Vector3 startGier;
public Vector3 endGier;
public Vector3 startNeid;
public Vector3 endNeid;
public Vector3 startPazifismus;
public Vector3 endPazifismus;
public Vector3 startWissen;
public Vector3 endWissen;

public Button KnopfLiebe;
public Button KnopfHass;
public Button KnopfGier;
public Button KnopfNeid;
public Button KnopfPazifismus;
public Button KnopfWissen;
private int buttonCounter = 0;
public int Auswahlmöglichkeiten;

public float Wartezeit;

    private void Start() {



    if (PlayerPrefs.GetFloat("LiebeX") == startLiebe.x && PlayerPrefs.GetFloat("LiebeY") == startLiebe.y || PlayerPrefs.GetFloat("LiebeX") == 0 || PlayerPrefs.GetFloat("LiebeY")== 0 )
    {
        liebe = startLiebe;
    } else {liebe = new Vector3 (PlayerPrefs.GetFloat("LiebeX"),PlayerPrefs.GetFloat("LiebeY"), 1);}
    

    if (PlayerPrefs.GetFloat("HassX") == startHass.x && PlayerPrefs.GetFloat("HassY") == startHass.y || PlayerPrefs.GetFloat("HassX") == 0)
    {
        hass = startHass;
    } else {hass = new Vector3 (PlayerPrefs.GetFloat("HassX"),PlayerPrefs.GetFloat("HassY"), 1);}
    
    if (PlayerPrefs.GetFloat("GierX") == startGier.x && PlayerPrefs.GetFloat("GierY") == startGier.y || PlayerPrefs.GetFloat("GierX") == 0 ||PlayerPrefs.GetFloat("GierY")== 0)
    {
        gier = startGier; 
    } else {gier = new Vector3 (PlayerPrefs.GetFloat("GierX"),PlayerPrefs.GetFloat("GierY"), 1);}

    if (PlayerPrefs.GetFloat("NeidX") == startNeid.x && PlayerPrefs.GetFloat("NeidY") == startNeid.y || PlayerPrefs.GetFloat("NeidX") == 0 ||PlayerPrefs.GetFloat("NeidY")== 0)
    {
        neid =  startNeid;
    } else {neid = new Vector3 (PlayerPrefs.GetFloat("NeidX"),PlayerPrefs.GetFloat("NeidY"), 1);}
    
    
    if (PlayerPrefs.GetFloat("PaziX") == startPazifismus.x && PlayerPrefs.GetFloat("PaziY") == startPazifismus.y || PlayerPrefs.GetFloat("PaziX") == 0)
    {
        pazifismus = startPazifismus;
    } else {pazifismus = new Vector3 (PlayerPrefs.GetFloat("PaziX"),PlayerPrefs.GetFloat("PaziY"), 1);}
    
    
    if (PlayerPrefs.GetFloat("WissenX") == startWissen.x && PlayerPrefs.GetFloat("WissenY") == startWissen.y || PlayerPrefs.GetFloat("WissenX") == 0 ||PlayerPrefs.GetFloat("WissenY")== 0)
    {
        wissen = startWissen;
    } else {wissen = new Vector3 (PlayerPrefs.GetFloat("WissenX"),PlayerPrefs.GetFloat("WissenY"), 1);}
    
    }

public void AddLiebe(float Amount){
 
 liebe = Vector3.MoveTowards(liebe,endLiebe,Amount);
KnopfLiebe.interactable = false;
 PlayerPrefs.SetFloat ("LiebeX", liebe.x);
 PlayerPrefs.SetFloat ("LiebeY", liebe.y);
 }
public void AddHass(float Amount){
 hass = Vector3.MoveTowards(hass,endHass,Amount);
 KnopfHass.interactable = false;
 PlayerPrefs.SetFloat ("HassX", hass.x);
 PlayerPrefs.SetFloat ("HassY", hass.y);
 }
 public void AddGier(float Amount){
 gier = Vector3.MoveTowards(gier,endGier,Amount);
KnopfGier.interactable = false;
 PlayerPrefs.SetFloat ("GierX", gier.x);
 PlayerPrefs.SetFloat ("GierY", gier.y);
 }



 public void AddNeid(float Amount){
 neid = Vector3.MoveTowards(neid,endNeid,Amount);
 KnopfNeid.interactable = false; 
 PlayerPrefs.SetFloat ("NeidX", neid.x);
 PlayerPrefs.SetFloat ("NeidY", neid.y);
 }



 public void AddPazifismus(float Amount){
 pazifismus = Vector3.MoveTowards(pazifismus,endPazifismus,Amount);
 KnopfPazifismus.interactable = false;
 PlayerPrefs.SetFloat ("PaziX", pazifismus.x);
 PlayerPrefs.SetFloat ("PaziY", pazifismus.y);
 }



 public void AddWissen(float Amount){
 wissen = Vector3.MoveTowards(wissen,endWissen,Amount);
 KnopfWissen.interactable = false;
 PlayerPrefs.SetFloat ("WissenX", wissen.x);
 PlayerPrefs.SetFloat ("WissenY", wissen.y);
 }


private int i = 0;
private int h = 0;
private int j = 0;
private int k = 0;
private int l = 0;
private int m = 0;


private void Update() {


// wenn eine entscheidung nur einmal gemacht werden darf 
//if (KnopfLiebe.IsInteractable() == false && i < 1) {   buttonCounter++; i++; }
//else if(KnopfHass.IsInteractable() == false && h <1) {   buttonCounter++; h++;}
//else if(KnopfNeid.IsInteractable() == false && j<1) {   buttonCounter++; j++;}
//else if(KnopfGier.IsInteractable() == false && k<1) {   buttonCounter++; k++;}
//else if(KnopfPazifismus.IsInteractable() == false && l<1) {   buttonCounter++; l++;}
//else if(KnopfWissen.IsInteractable() == false && m<1) {  buttonCounter++; m++;}


//if (buttonCounter >= Auswahlmöglichkeiten )
//{
//   KnopfLiebe.interactable = false;
//   KnopfHass.interactable = false;
//   KnopfGier.interactable = false;
//   KnopfNeid.interactable = false; 
//   KnopfPazifismus.interactable = false;
//   KnopfWissen.interactable = false;

//   Invoke("endScene", Wartezeit); 

//}

drawHexagon.SetPosition(0,liebe);
drawHexagon.SetPosition(1,hass);
drawHexagon.SetPosition(2,gier);
drawHexagon.SetPosition(3,neid);
drawHexagon.SetPosition(4,pazifismus);    
drawHexagon.SetPosition(5,wissen);
}

 private void OnDestroy() {
 
 //PlayerPrefs.SetFloat ("LiebeX", liebe.x);  PlayerPrefs.SetFloat ("LiebeY", liebe.y);  PlayerPrefs.SetFloat ("HassX", hass.x);  PlayerPrefs.SetFloat ("HassY", hass.y);  PlayerPrefs.SetFloat ("GierX", gier.x);  PlayerPrefs.SetFloat ("GierY", gier.y);   PlayerPrefs.SetFloat ("NeidX", neid.x);  PlayerPrefs.SetFloat ("NeidY", neid.y);  PlayerPrefs.SetFloat ("PaziX", pazifismus.x); PlayerPrefs.SetFloat ("PaziY", pazifismus.y); PlayerPrefs.SetFloat ("WissenX", wissen.x); PlayerPrefs.SetFloat ("WissenY", wissen.y);


 //PlayerPrefs.SetFloat ("LiebeX", startLiebe.x);
 //PlayerPrefs.SetFloat ("LiebeY", startLiebe.y);

 //PlayerPrefs.SetFloat ("HassX", startHass.x);
 //PlayerPrefs.SetFloat ("HassY", startHass.y);

 //PlayerPrefs.SetFloat ("GierX", startGier.x);
 //PlayerPrefs.SetFloat ("GierY", startGier.y);

 //PlayerPrefs.SetFloat ("NeidX", startNeid.x);
 //PlayerPrefs.SetFloat ("NeidY", startNeid.y);
 
 //PlayerPrefs.SetFloat ("PaziX", startPazifismus.x);
 //PlayerPrefs.SetFloat ("PaziY", startPazifismus.y);
 
 //PlayerPrefs.SetFloat ("WissenX", startWissen.x);
 //PlayerPrefs.SetFloat ("WissenY", startWissen.y);
 print(liebe);
 
 }

private void endScene () {
 SceneManager.LoadScene("Night", LoadSceneMode.Single);
 }


}