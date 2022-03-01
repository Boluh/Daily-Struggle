using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeNpc : MonoBehaviour
{
    private  float randomNumber;
    public int NPC;
    public GameObject one;
    public GameObject two;
    public GameObject three;
public GameObject four;
public GameObject five;
public GameObject six;
    void Awake()
    {
        randomNumber = Random.Range(1,6);
        NPC = Mathf.RoundToInt(randomNumber);
        if (NPC == 1 || NPC == 0)
        {
            one.SetActive(true);
        }
               
         if (NPC == 2)
        {
            two.SetActive(true);
        }       
         if (NPC == 3)
        {
            three.SetActive(true);
        }       
         if (NPC == 4)
        {
            four.SetActive(true);
        }        
        if (NPC == 5)
        {
            five.SetActive(true);
        }        
        if (NPC == 6)
        {
            six.SetActive(true);
        }
    }
public void setToLieb (){
PlayerPrefs.SetInt("Liebhaber",NPC);

}


 
}
