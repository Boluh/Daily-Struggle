using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class EndText : MonoBehaviour
{

public Text endText;
public GameObject Liebe;
public GameObject Hass;
public GameObject Gier;
public GameObject Neid;
public GameObject Pazifismus;
public GameObject Wissen;

private void Awake() {

if ("liebe" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndLiebe"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Liebe.SetActive(true);
}
if ("hass" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndHass"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Hass.SetActive(true);
}
if ("gier" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndGier"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Gier.SetActive(true);
}
if ("neid" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndNeid"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Neid.SetActive(true);
}
if ("pazifismus" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndPazifismus"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Pazifismus.SetActive(true);
}
if ("wissen" == PlayerPrefs.GetString("ActiveEnd")){
string recallText = Application.dataPath + "/TextAssets/" + "EndWissen"  + ".txt";
List<string> fileLines = File.ReadAllLines(recallText).ToList();

      
endText.text = fileLines[0];
Wissen.SetActive(true);
}
}






}
