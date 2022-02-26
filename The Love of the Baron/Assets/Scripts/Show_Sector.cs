using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Sector : MonoBehaviour
{
    public GameObject Sector;
    public GameObject UI; 
    private float checkInput;
    void Start()
    {
        Sector.SetActive(false);
        UI.SetActive(true);
    }

  
    void Update()
    {
        checkInput = Input.GetAxis("Open Sector") * Time.deltaTime * 1 ;

        if (checkInput != 0 ) {
            Sector.SetActive(true);
            Sector.transform.position = new Vector3 (0,0,0);
            UI.SetActive(false); 
        }
        else {Sector.SetActive(false);
        UI.SetActive(true); }
    }
}
