using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    public GameObject Entscheidungen;
    public GameObject Bereiche;
    public GameObject Diener;
    private float checkInput;

    public string activeDiener;
    public int DienerCount = 0;
    private Track_Decisions setLastDecision;

private void OnEnable() {
    Entscheidungen.SetActive(false);
    Bereiche.SetActive(false);
    Diener.SetActive(true);
    }
    void Update()
    { 
        if (DienerCount >= 3){ setLastDecision.lastDecision = true;} 




    //    checkInput = Input.GetAxis("Open Sector") * Time.deltaTime * 1 ;
    //    if (checkInput != 0 ) {
    //        Bereiche.SetActive(true);
    //        Bereiche.transform.position = new Vector3 (0,0,0);
    //        Entscheidungen.SetActive(false);
    //        Diener.SetActive(false); 
    //    }
    //    else {Bereiche.SetActive(false);   }

    }

    public void goToDecisions(){
    Entscheidungen.SetActive(true);
    Bereiche.SetActive(false);
    Diener.SetActive(false);
    }
    public void goToDiener() {
    Invoke("setToDiener",1);
    }
    public void setToBernard(){
    activeDiener = "Bernard";  DienerCount++;  
    }
    public void setToWolfgang(){
    activeDiener = "Wolfgang";   DienerCount++; 
    }
    public void setToJosephine(){
    activeDiener = "Josephine"; DienerCount++;
    }
    public void setToAlfons(){
    activeDiener = "Alfons & Philippa"; DienerCount++;
    }

    private void setToDiener() {
    Entscheidungen.SetActive(false);
    Bereiche.SetActive(false);
    Diener.SetActive(true);         
    }

    }