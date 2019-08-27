using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    float cont;
    public float timeToDestroy;
	// Update is called once per frame
	void Update () {
        cont += Time.deltaTime;
        if (cont >= timeToDestroy)
        {
            Destroy(this.gameObject);
        }
	}
}
