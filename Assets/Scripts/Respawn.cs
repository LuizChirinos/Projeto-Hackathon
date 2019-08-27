using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public float tempopararespawn;
	public float tempo;
	public GameObject caries;
	public Transform[] dentes;
	public float limitecaries;
	public static float contagemcaries;

    public static bool respawna;


	void Start ()
	{
        contagemcaries = 0f;
        limitecaries = 20f;
        respawna = false;
	}

	// Update is called once per frame
	void Update () {
        Debug.Log("RESPAWNOU " + respawna);

        if (contagemcaries >= limitecaries)
        {
            MataAlgo.pontosescova -= 0.01f;
        }


        //adiciona tempo na variável tempo
        if (respawna)
        {
            tempo += Time.deltaTime;

            //Debug.Log("Contagem caries" + contagemcaries);

            //Perde ponto enquanto tiver 20 cáries


            //checa se a variável alcançou o tempo de spawn
            if (tempo > Mathf.Abs(tempopararespawn))
            {
                //Debug.Log("Spawnou");
                SpawnaManchas();
                //zera o tempo
                tempo = 0f;
                //diminui tempo para respawn
                tempopararespawn -= 0.1f;
            }

            if (Mathf.Abs(tempopararespawn) < 0.5f)
            {
                respawna = false;
                tempopararespawn = 3f;
            }
        }
	}

	void SpawnaManchas()
	{
		if (contagemcaries <= limitecaries) {
			int sorteio = Random.Range (0, 20);
			//Debug.Log ("sorteio " + sorteio);
			Vector3 variacao = new Vector3 (0.02f, 0.02f, 0.0f);
			Instantiate (caries, dentes [sorteio].position + variacao, Quaternion.identity);
			contagemcaries += 1f;

		}
	}
}
