using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugadorDeAgua : MonoBehaviour
{

    public Vector3 mousePos;
    Vector3 mouse2Dpos;
    public static bool sugou;
    public bool apertoumouse;
    public bool colidiu;
    public float tempoSugador;
    public float limiteSugador;

    // Use this for initialization
    void Start()
    {
        sugou = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("ApertouMouse " + apertoumouse);
        //Debug.Log("Colidiu " + colidiu);
        Debug.Log("Sugou" + sugou);

        apertoumouse = Input.GetMouseButton(0);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse2Dpos = new Vector3(mousePos.x, mousePos.y, 0f);
        if (sugou == false)
        {
            //if (apertoumouse)
            //{
                if (colidiu)
                {
                    Debug.Log("Sugou");
                    //acontecer várias vezes até chegar ao certo tempo
                    Jorrador.tempoJorrador -= Time.deltaTime;
                    Debug.Log("delta");
                    //sugou = true;
                }
            //}
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.tag == "sugador")
        {
            //comandos para detectar se jorrador colidiu
            colidiu = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "sugador")
        {
            //comandos para detectar se jorrador deixou de colidir
            colidiu = false;
        }
    }
}
