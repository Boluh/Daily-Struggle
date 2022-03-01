using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowSectionWheel : MonoBehaviour
{
    public GameObject SectionWheel;
    public static bool ShowSectionWheels = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (ShowSectionWheels)
            {
                Hide();
            }
            else
            {
                Show();
            }
        }
    }
    public void Hide()
    {
        SectionWheel.SetActive(false);
        Time.timeScale = 1f;
        ShowSectionWheels = false;
    }

    void Show()
    {
        SectionWheel.SetActive(true);
        Time.timeScale = 0f;
        ShowSectionWheels = true;
    }
}
