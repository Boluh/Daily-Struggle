using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detecthovering : MonoBehaviour
{
    public Animator animator;
    public GameObject dienerName;
 

private void OnMouseEnter() {
    animator.SetBool("hoovering", true);
    dienerName.SetActive(true);
    }
private void OnMouseExit() {
    animator.SetBool("hoovering", false);
    dienerName.SetActive(false);
}
}
