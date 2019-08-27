using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jorrador : MonoBehaviour {

    [Header("Variáveis do Mouse")]
    public Vector3 mousePos;
    Vector3 mouse2Dpos;
    public static bool jorrou;
    public bool apertoumouse;
    public bool colidiu;

    [Header("Variáveis do Jorrador")]
    public static float tempoJorrador;
    public float limiteJorrador;

    [Header("Variáveis dos Buchehco")]
    public float yTile;
    public SpriteRenderer renderBuchecho;


    // Use this for initialization
    void Start () {
        jorrou = false;
        //Cursor.visible = false;
        tempoJorrador = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("ApertouMouse " + apertoumouse);
        //Debug.Log("Colidiu " + colidiu);
        Debug.Log("Jorrou " + jorrou);

        //Limita tile do Buchecho
        yTile = Mathf.Clamp(yTile, 0f, 4f);
        yTile = tempoJorrador;
        renderBuchecho.size = new Vector2(renderBuchecho.size.x, yTile);


        apertoumouse = Input.GetMouseButton(0);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse2Dpos = new Vector3(mousePos.x, mousePos.y, 0f);
        if (jorrou == false)
        {
                if (colidiu)
                {
                    Debug.Log("Jorrou");
                    //acontecer várias vezes até chegar ao certo tempo
                    tempoJorrador += Time.deltaTime;
                    Debug.Log("delta");
                    //jorrou = true;
                }
            
        }

        if (tempoJorrador >= limiteJorrador)
        {
            jorrou = true;
            Debug.Log("jorrouTrue");
        }


        if (tempoJorrador <= 0)
        {
            jorrou = false;
            Debug.Log("tirou Agua");

        }

        tempoJorrador = Mathf.Clamp(tempoJorrador, 0f, 4f);

        Debug.Log("tempoJorrador " + tempoJorrador);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.tag == "jorra")
        {
            //comandos para detectar se jorrador colidiu
            colidiu = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "jorra")
        {
            //comandos para detectar se jorrador deixou de colidir
            colidiu = false;
        }
    }
}
