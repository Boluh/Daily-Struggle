using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetPrefs : MonoBehaviour
{
[SerializeField] Track_Decisions  hooka; 

private void Awake() {
 PlayerPrefs.SetFloat ("LiebeX", hooka.startLiebe.x);
 PlayerPrefs.SetFloat ("LiebeY", hooka.startLiebe.y);

 PlayerPrefs.SetFloat ("HassX", hooka.startHass.x);
 PlayerPrefs.SetFloat ("HassY", hooka.startHass.y);

 PlayerPrefs.SetFloat ("GierX", hooka.startGier.x);
 PlayerPrefs.SetFloat ("GierY", hooka.startGier.y);

 PlayerPrefs.SetFloat ("NeidX", hooka.startNeid.x);
 PlayerPrefs.SetFloat ("NeidY", hooka.startNeid.y);
 
 PlayerPrefs.SetFloat ("PaziX", hooka.startPazifismus.x);
 PlayerPrefs.SetFloat ("PaziY", hooka.startPazifismus.y);
 
 PlayerPrefs.SetFloat ("WissenX", hooka.startWissen.x);
 PlayerPrefs.SetFloat ("WissenY", hooka.startWissen.y);

 PlayerPrefs.SetInt("dayCount",1);
 
 
 PlayerPrefs.SetFloat("Geld",100);
 PlayerPrefs.SetFloat("Zuneigung",100);
 PlayerPrefs.SetFloat("Stärke",100);
 
}

}
