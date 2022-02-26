using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    private void Start() {
    liebe = startLiebe;
    hass = startHass;
    gier = startGier;
    neid =  startNeid;
    pazifismus = startPazifismus;
    wissen = startWissen;
    }

public void AddLiebe(float Amount){
 
 liebe = Vector3.MoveTowards(liebe,endLiebe,Amount);
KnopfLiebe.interactable = false;
 }
public void AddHass(float Amount){
 hass = Vector3.MoveTowards(hass,endHass,Amount);
 KnopfHass.interactable = false;
 }
 public void AddGier(float Amount){
 gier = Vector3.MoveTowards(gier,endGier,Amount);
KnopfGier.interactable = false;
 }
 public void AddNeid(float Amount){
 neid = Vector3.MoveTowards(neid,endNeid,Amount);
 KnopfNeid.interactable = false;
 }
 public void AddPazifismus(float Amount){
 pazifismus = Vector3.MoveTowards(pazifismus,endPazifismus,Amount);
 KnopfPazifismus.interactable = false;
 }
 public void AddWissen(float Amount){
 wissen = Vector3.MoveTowards(wissen,endWissen,Amount);
 KnopfWissen.interactable = false;
 }


private int i = 0;
private int h = 0;
private int j = 0;
private int k = 0;
private int l = 0;
private int m = 0;
private void Update() {


if (KnopfLiebe.IsInteractable() == false && i < 1) {   buttonCounter++; i++; }
else if(KnopfHass.IsInteractable() == false && h <1) {   buttonCounter++; h++;}
else if(KnopfNeid.IsInteractable() == false && j<1) {   buttonCounter++; j++;}
else if(KnopfGier.IsInteractable() == false && k<1) {   buttonCounter++; k++;}
else if(KnopfPazifismus.IsInteractable() == false && l<1) {   buttonCounter++; l++;}
else if(KnopfWissen.IsInteractable() == false && m<1) {  buttonCounter++; m++;}


if (buttonCounter >= Auswahlmöglichkeiten )
{
   KnopfLiebe.interactable = false;
   KnopfHass.interactable = false;
   KnopfGier.interactable = false;
   KnopfNeid.interactable = false; 
   KnopfPazifismus.interactable = false;
   KnopfWissen.interactable = false;

   //NEUE SZENE LADEN

} 
drawHexagon.SetPosition(0,liebe);
drawHexagon.SetPosition(1,hass);
drawHexagon.SetPosition(2,gier);
drawHexagon.SetPosition(3,neid);
drawHexagon.SetPosition(4,pazifismus);    
drawHexagon.SetPosition(5,wissen);
}

}
