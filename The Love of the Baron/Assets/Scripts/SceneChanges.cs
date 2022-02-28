using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanges : MonoBehaviour
{


    // Start is called before the first frame update
public void GoToNight () {

SceneManager.LoadScene("Night", LoadSceneMode.Single);

}

public void GoToDay () {
SceneManager.LoadScene("Day", LoadSceneMode.Single);
}

public void GoToFirstDay () {
    SceneManager.LoadScene("FirstDay", LoadSceneMode.Single);
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
}
