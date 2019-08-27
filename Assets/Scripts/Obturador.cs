using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obturador : MonoBehaviour {

    public Vector3 mousePos;
    Vector3 mouse2Dpos;
    public static bool obturou;
    public bool apertoumouse;
    public bool colidiu;
   
    // Use this for initialization
    void Start()
    {
        obturou = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("ApertouMouse " + apertoumouse);
        //Debug.Log("Colidiu " + colidiu);
        Debug.Log("obturou " + obturou);

        apertoumouse = Input.GetMouseButton(0);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse2Dpos = new Vector3(mousePos.x, mousePos.y, 0f);
        if (obturou == false)
        {
            if (apertoumouse)
            {
                if (colidiu)
                {
                    obturou = true;
                }
            }
        }




        //if (tempoObturador <= 0)
        //{
        //    tempoObturador = 0f;
        //    obturou = false;

        //}

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log(col.gameObject.name);
        if (col.tag == "obturador")
        {
            //comandos para detectar se jorrador colidiu
            colidiu = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "obturador")
        {
            //comandos para detectar se jorrador deixou de colidir
            colidiu = false;
        }
    }

}
