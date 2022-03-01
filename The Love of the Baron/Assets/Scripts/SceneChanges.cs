using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanges : MonoBehaviour
{

private int sceneToChange;
    // Start is called before the first frame update
public void GoToNight () {

SceneManager.LoadScene("Night", LoadSceneMode.Single);
}

public void GoToDay () {
SceneManager.LoadScene("Day", LoadSceneMode.Single);
}

public void GoToFirstDay () {
    PlayerPrefs.SetInt("dayCount",1);
    SceneManager.LoadScene("Day", LoadSceneMode.Single);
    }

public void GoToMainMenu () {
    SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
}

public void GoToDeathScreen() {
SceneManager.LoadScene("DeathScreen", LoadSceneMode.Single);
}

public void GoToEnd(){
SceneManager.LoadScene("EndScene", LoadSceneMode.Single); 
 
}

public void continueAtLastScene (){
    sceneToChange = PlayerPrefs.GetInt("SavedScene");
    if (sceneToChange != 0){SceneManager.LoadScene(sceneToChange);}
    else
    {
        return;
    }
}
}
