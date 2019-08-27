using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheatSceneChanger : MonoBehaviour {

    public Text textoInput;

    public void GoToInputScene()
    {
        SceneManager.LoadScene(textoInput.text);
    }
}
