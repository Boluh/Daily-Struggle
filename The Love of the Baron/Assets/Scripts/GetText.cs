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
 public Text Intro;
public changeNpc npc;
 private string activeDiener;
[SerializeField] public int dayCount;

private void Awake() {
    dayCount = PlayerPrefs.GetInt("dayCount");
}
private void OnEnable() {
    string recallText = Application.dataPath + "/TextAssets/" + "Introtext" + dayCount.ToString() + ".txt";
    List<string> fileLines = File.ReadAllLines(recallText).ToList();

    Intro.text = fileLines[0];        
        
    
}


private int npcs;
private void Update() {

}
public void setTextAnfrage(){
    npcs = npc.NPC;
    if (npcs == 1)
    {
        activeDiener = "Alfons";
    }
    if (npcs == 2 )
    {
        activeDiener = "Richard";
    }
        if (npcs == 3)
    {
        activeDiener = "Elenor";
    }
            if (npcs == 4)
    {
        activeDiener = "Victoria";
    }
            if (npcs == 5)
    {
        activeDiener = "Frieda";
    }
            if (npcs == 6)
    {
        activeDiener = "Maximilian";
    }
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