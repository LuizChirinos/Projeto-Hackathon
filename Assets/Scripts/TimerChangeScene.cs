using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerChangeScene : MonoBehaviour {

    public float timeToWait;
    public string sceneToGo;
    float cont;
	
	// Update is called once per frame
	void Update () {
        cont += Time.deltaTime;
        if (cont >= timeToWait)
        {
            SceneManager.LoadScene(sceneToGo);
        }
	}
}
