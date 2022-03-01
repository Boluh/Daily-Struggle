using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetPrefs : MonoBehaviour
{

public void resetStats() {
 PlayerPrefs.SetFloat ("LiebeY", -0.35f);

 PlayerPrefs.SetFloat ("HassX", 0.5f);
 PlayerPrefs.SetFloat ("HassY", 0);

 PlayerPrefs.SetFloat ("GierX", 0.25f);
 PlayerPrefs.SetFloat ("GierY", 0.35f);

 PlayerPrefs.SetFloat ("NeidX", -0.25f);
 PlayerPrefs.SetFloat ("NeidY", 0.35f);
 
 PlayerPrefs.SetFloat ("PaziX", -0.5f);
 PlayerPrefs.SetFloat ("PaziY", 0);
 
 PlayerPrefs.SetFloat ("WissenX", -0.25f);
 PlayerPrefs.SetFloat ("WissenY", -0.35f);

 PlayerPrefs.SetInt("dayCount",1);
 
 
 PlayerPrefs.SetFloat("Geld",100);
 PlayerPrefs.SetFloat("Zuneigung",100);
 PlayerPrefs.SetFloat("Stärke",100);
PlayerPrefs.SetFloat ("LiebeX", 0.25f);
 
}

}
