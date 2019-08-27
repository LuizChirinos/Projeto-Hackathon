using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Relogio : MonoBehaviour {


    
	public static float tempo;
    public float tempoRefeicao;
    
    [Header("Variáveis para Tempo do Relógio e Ponteiro")]
    private float anglePointer;
    [Header("Pega a velocidade e multiplica pelo pointerSpeed,\n\n\n\n\n o tempo em segundos será 360/pointerSpeed")]
    [SerializeField] float relativeTime;
    public Transform pointer;

    public float pointerSpeed;

    [Header("Horários das refeições")]
	public float horariocafe;
	public float horarioalmoco;
	public float horariolanche;
	public float horariojanta;
    public float horarioRefeicao;
    public int indice;


    [Header("Variáveis para indicar refeições")]
    public Text textRefeicao;
    public string[] refeicoes;
    public Animator anim;

	// Use this for initialization
	void Start () {
        horarioRefeicao = horariocafe;
        indice = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //Adiciona o tempo na variável
		tempo += Time.deltaTime;
        tempoRefeicao += (Time.deltaTime * 3) % 360; 

        //limita a variável anglePointer a valores entre 0 e 360
        anglePointer = (tempo * pointerSpeed) % 360;

        relativeTime = anglePointer;

        if (relativeTime > 270)
        {
            MainData.pontos = Pontuacao.pontos;
            SceneManager.LoadScene("Vitoria");
        }

        //if (anglePointer >= 360)
        //    anglePointer = 0f;

        pointer.transform.eulerAngles = new Vector3(0f, 0f, -anglePointer);

        /*
        if (relativeTime > horariojanta)
        {
            Debug.Log("deu horario da janta");
            anim.SetTrigger("horaDaRefeicao");
            textRefeicao.text = refeicoes[0];
            Respawn.respawna = true;
        }


        else if (relativeTime > horariolanche)
        {
            Debug.Log("deu horario do lanche");
            anim.SetTrigger("horaDaRefeicao");

            textRefeicao.text = refeicoes[1];
            Respawn.respawna = true;
        }


        else if (relativeTime > horarioalmoco)
        {
            Debug.Log("deu horario do almoco");
            anim.SetTrigger("horaDaRefeicao");

            textRefeicao.text = refeicoes[2];
            Respawn.respawna = true;
        }

        else if (relativeTime > horariocafe)
        {
            Debug.Log("deu horario do cafe");
            anim.SetTrigger("horaDaRefeicao");

            textRefeicao.text = refeicoes[3];
            Respawn.respawna = true;
        }*/

        if (tempoRefeicao > horarioRefeicao)
        {
            if (indice <= refeicoes.Length-1)
            {
                Debug.Log("Passou do hora de comer");

                textRefeicao.text = refeicoes[indice];

                if (horarioRefeicao >= horariocafe)
                {
                    horarioRefeicao = horarioalmoco;
                    tempoRefeicao = 0f;
                    Respawn.respawna = true;

                    anim.SetTrigger("horaDaRefeicao");
                    indice++;
                }
                else if (horarioRefeicao >= horarioalmoco)
                {
                    horarioRefeicao = horariolanche;
                    tempoRefeicao = 0f;
                    Respawn.respawna = true;

                    anim.SetTrigger("horaDaRefeicao");
                    indice++;
                }

                else if (horarioRefeicao >= horariolanche)
                {
                    horarioRefeicao = horariojanta;
                    tempoRefeicao = 0f;
                    Respawn.respawna = true;

                    anim.SetTrigger("horaDaRefeicao");
                    indice++;
                }

                else if (horarioRefeicao >= horariojanta)
                {
                    horarioRefeicao = horariocafe;
                    tempoRefeicao = 0f;
                    Respawn.respawna = true;

                    anim.SetTrigger("horaDaRefeicao");
                    indice++;
                }
            }

            else
            {
                Debug.Log("passou um dia");
            }
        }

        
    }
}
