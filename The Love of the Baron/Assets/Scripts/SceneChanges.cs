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
}
