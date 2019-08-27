using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript;

public class areainstrumentos : MonoBehaviour {

	public Transform[] posicoes;
	public Transform[] instrumentos;
	public bool saiu;
	public bool apertoumouse;

	void Update()
	{
		apertoumouse = Input.GetMouseButtonDown (0);
	}

	void OnTriggerExit2D(Collider2D other){
		{
			if (apertoumouse == false) {
				Debug.Log ("Saiu");
				if (other.tag == "limpador") {
					instrumentos [0].position = posicoes [0].position;
				}
			}

		}
	}
}
