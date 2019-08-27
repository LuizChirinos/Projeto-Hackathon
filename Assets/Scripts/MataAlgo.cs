using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MataAlgo : MonoBehaviour {

	public int vida;
	public static float pontoslimpador;
	public static float pontosescova;
    public static float pontosobturador;


	void Start()
	{
		vida = 70;
	}
	void Update()
	{
		if (pontosescova <= 0f) {
			pontosescova = 0f;
		}

		if (this.vida <= 0)
		{
			Respawn.contagemcaries -= 1f;
			pontosescova += 5f;
			Destroy (this.gameObject);
		}


	}


	void OnTriggerStay2D(Collider2D other)
	{
        if (other.tag == "escova")
        {
            Debug.Log("Está escovando");
            //pontosescova += 1f;
            //perde vida
            this.vida -= 1;
        }

        if (Jorrador.jorrou)
        {
            if (gameObject.tag == "manchas")
            {
                if (other.tag == "limpador")
                {
                    Debug.Log("Está limpando");
                    pontoslimpador += 1f;
                    //perde vida
                    this.vida -= 1;
                }
            }
        }

        if (Jorrador.jorrou == false)
        {
            if (gameObject.tag == "caries")
            {
                if (other.tag == "obturador")
                {
                    Debug.Log("Está obturando");
                    pontosobturador += 1f;
                    //perde vida
                    this.vida -= 1;
                }
            }
        }
    }
}
