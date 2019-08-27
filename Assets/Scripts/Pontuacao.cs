using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pontuacao : MonoBehaviour {

	public Text textopontos;
	public static int pontos;
    public string nextScene;
    public int winPoints;


	void Update()
	{
		pontos = (int)MataAlgo.pontosescova;
		textopontos.text = "Pontos \n" + pontos.ToString ();
		//Debug.Log (" pontos escova " + pontosescova);

        if (pontos >= winPoints)
        {
            MataAlgo.pontosescova = 0;

            SceneManager.LoadScene(nextScene);
        }
	}
}
