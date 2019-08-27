using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaInstrumento : MonoBehaviour {

	public Vector3 mousePos;
    Vector3 mouse2Dpos;
    bool podePegar;


    void Update()
	{
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        mouse2Dpos = new Vector3(mousePos.x, mousePos.x, 0f);

        if (this.podePegar)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.transform.position = mouse2Dpos;
            }
        }
	}

	void OnMouseOver()
	{
        print(gameObject.name);
        if (gameObject.tag == "Instrumento")
        {
            podePegar = true;
        }
    }
}
