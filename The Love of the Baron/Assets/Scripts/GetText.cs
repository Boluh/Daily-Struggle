using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class GetText : MonoBehaviour
{
 
 public Transform contentWindow;
 public GameObject recallTextObject;
        void Start()
    {
        string anfrage = Application.dataPath + "/TextAssets" + "Placeholder" + ".txt";

        recallTextObject.GetComponent<Text>().text = anfrage;
       
    }


}
