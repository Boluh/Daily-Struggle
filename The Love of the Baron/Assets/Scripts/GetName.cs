using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
 public Text dienerName;

 private void Start() {
     dienerName.text = this.name; 
 }
}
