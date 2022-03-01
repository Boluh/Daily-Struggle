using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScore : MonoBehaviour
{
public Text geld;
private float money;
public Text Zuneigung;
private float love;
public Text stärke;
private float strength;

private void Awake() {
    money = PlayerPrefs.GetFloat("Geld");
    geld.text = money.ToString();
    love = PlayerPrefs.GetFloat("Zuneigung");
    Zuneigung.text = love.ToString();
    strength = PlayerPrefs.GetFloat("Stärke");
    stärke.text = strength.ToString();
}
}
