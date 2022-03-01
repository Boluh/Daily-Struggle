using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCount : MonoBehaviour
{
    [SerializeField] int Day;
    private void Awake() {
        Day = PlayerPrefs.GetInt("dayCount");

    }
public void updayCount() {
Day = PlayerPrefs.GetInt("dayCount") + 1;
PlayerPrefs.SetInt("dayCount",Day);
}

}
