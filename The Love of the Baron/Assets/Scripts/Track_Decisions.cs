using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_Decisions : MonoBehaviour
{
    
    public Vector2 liebe;
    public Vector2 hass;
    public Vector2 gier;
    public Vector2 neid;
    public Vector2 pazifismus;
    public Vector2 wissen;
    

public void AddLiebe(float Amount){
 liebe = liebe + new Vector2 (0,Amount);
 }
public void AddHass(float Amount){
 hass = hass + new Vector2 (0,Amount);
 }
 public void AddGier(float Amount){
 gier = gier + new Vector2 (0,Amount);
 }
 public void AddNeid(float Amount){
 neid = neid + new Vector2 (0,Amount);
 }
 public void AddPazifismus(float Amount){
 pazifismus = pazifismus + new Vector2 (0,Amount);
 }
 public void AddWissen(float Amount){
 wissen = wissen + new Vector2 (0,Amount);
 }
}
