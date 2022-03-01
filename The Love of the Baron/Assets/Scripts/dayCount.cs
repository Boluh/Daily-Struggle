using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCount : MonoBehaviour
{
private int Day = 1;
public void updayCount() {
Day = PlayerPrefs.GetInt("dayCount") + 1;
PlayerPrefs.SetInt("dayCount",Day);
}

}
