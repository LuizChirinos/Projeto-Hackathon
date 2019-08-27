using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosFeitos : MonoBehaviour {

    public Text textoPontosFeitos;

	// Use this for initialization
	void Start () {
        textoPontosFeitos.text = "Você fez " + MainData.pontos.ToString() + " pontos";
	}
}
