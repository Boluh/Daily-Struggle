using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class GetText : MonoBehaviour
{
 
 
 public Text anfrage;
 public Text liebeText;
 public Text hassText;
 public Text gierText;
 public Text neidText;
 public Text pazifismusText;
 public Text wissenText;

 private string activeDiener;
[SerializeField] public int dayCount = PlayerPrefs.GetInt("dayCount");
 
        void Start()
    {

        

    }
private void Update() {

}
public void setTextAnfrage(string activeDiener){
    string recallText = Application.dataPath + "/TextAssets/" + activeDiener + dayCount.ToString() + ".txt";
    List<string> fileLines = File.ReadAllLines(recallText).ToList();

    anfrage.text = fileLines[0];
    liebeText.text = fileLines[1];      
    hassText.text = fileLines[2];
    gierText.text = fileLines[3];
    neidText.text = fileLines[4];  
    pazifismusText.text = fileLines[5];
    wissenText.text = fileLines[6];
}

}