using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class GetText : MonoBehaviour
{
 
 
 public GameObject recallTextObject;
 public Transform anfragenText;
        void Start()
    {

        

        string anfrage = Application.dataPath + "/TextAssets" + "Placeholder" + ".txt";
        List<string> fileLines = File.ReadAllLines(anfrage).ToList();
        
        
         foreach (string line in fileLines)
         {
             Instantiate(recallTextObject,anfragenText);
             recallTextObject.GetComponent<Text>().text = anfrage;
         }
        


        

    }


}