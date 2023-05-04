using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAlerta : MonoBehaviour
{
    public float velocidadGiroBusqueda = 120f;

    public float duracionBusqueda = 4f;


    private MaquinaDeEstados maquinaDeEstados;
    private NavMesh navMesh;
    private Vision vision;

    //private float tiempoBuscando;
    public bool estado;
    public float superTime;



    void Awake()
    {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        navMesh = GetComponent<NavMesh>();
        vision = GetComponent<Vision>();
    }

    void OnEnable()
    {
        navMesh.DetenerNMA();
        //tiempoBuscando = 0f;
        estado = true;

    }
   
    void Update()
    {

        RaycastHit hit;
        if (vision.verAlJugador(out hit))
        {
            navMesh.perseguirObjetivo = hit.transform;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPersecucion);
            return;
        }
        
        transform.Rotate(0f, velocidadGiroBusqueda * Time.deltaTime, 0f);

        if (estado)
        {
            StartCoroutine("Timer");
            estado = false;
        }
        
        if(superTime >= duracionBusqueda)
        {
            superTime = 0f;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoNormal);
            return;
        }

    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(4f);
        superTime += 4f;
    }
}

