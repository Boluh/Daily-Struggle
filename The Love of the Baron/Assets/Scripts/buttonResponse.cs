using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonResponse : MonoBehaviour

{

public Track_Decisions Response;
public Button Liebe;
public Button Hass;
public Button Gier;
public Button Neid;
public Button Pazifismus;
public Button Wissen;
public float VeränderungBereich;
    void Start()
    {
        
    }


    void Update()
    {

        if (Liebe == true)
        {
            Response.AddLiebe(VeränderungBereich);
            Liebe.interactable = false; 
        }
                if (Hass == true)
        {
            Response.AddHass(VeränderungBereich);
        }
                if (Gier == true)
        {
            Response.AddGier(VeränderungBereich);
        }
                if (Neid == true)
        {
            Response.AddNeid(VeränderungBereich);
        }
                if (Pazifismus == true)
        {
            Response.AddPazifismus(VeränderungBereich);
        }
                if (Wissen == true)
        {
            Response.AddWissen(VeränderungBereich);
        }
    }
}
