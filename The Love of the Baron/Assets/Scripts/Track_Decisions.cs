using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

 }
public void AddHass(float Amount){
 hass = Vector3.MoveTowards(hass,endHass,Amount);
 }
 public void AddGier(float Amount){
 gier = Vector3.MoveTowards(gier,endGier,Amount);

 }
 public void AddNeid(float Amount){
 neid = Vector3.MoveTowards(neid,endNeid,Amount);
 }
 public void AddPazifismus(float Amount){
 pazifismus = Vector3.MoveTowards(pazifismus,endPazifismus,Amount);
 }
 public void AddWissen(float Amount){
 wissen = Vector3.MoveTowards(wissen,endWissen,Amount);
 }

private void Update() {
drawHexagon.SetPosition(0,liebe);
drawHexagon.SetPosition(1,hass);
drawHexagon.SetPosition(2,gier);
drawHexagon.SetPosition(3,neid);
drawHexagon.SetPosition(4,pazifismus);    
drawHexagon.SetPosition(5,wissen);


}

}
