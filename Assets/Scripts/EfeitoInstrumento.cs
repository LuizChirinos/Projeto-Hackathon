using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoInstrumento : MonoBehaviour {

    public ParticleSystem efeito;
    ParticleSystem.EmitParams emitParams;
    void Start()
    {
        emitParams = new ParticleSystem.EmitParams();
        //efeito.Stop();
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "manchas")
        {
            efeito.Emit(emitParams, 10);
        }
        else if (col.gameObject.tag == "caries")
        {
            efeito.Emit(emitParams, 10);
        }
        else if (col.gameObject.tag == "tartaro")
        {
            efeito.Emit(emitParams, 10);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "manchas")
        {
            efeito.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }
        else if (col.gameObject.tag == "caries")
        {
            efeito.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }
        else if (col.gameObject.tag == "tartaro")
        {
            efeito.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }

    }
}
