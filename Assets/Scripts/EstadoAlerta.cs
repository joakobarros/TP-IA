using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAlerta : MonoBehaviour
{
    public float velocidadGiroBusqueda = 120f;

    //busqueda
    public float duracionBusqueda = 4f;

    private MaquinaDeEstados maquinaDeEstados;
    private NavMesh navMesh;
    private Vision vision;

    //busqueda
    private float tiempoBuscando;

    void Awake()
    {
        navMesh = GetComponent<NavMesh>();
        vision = GetComponent<Vision>();
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
    }

    void OnEnable()
    {
        navMesh.DetenerNMA();
        tiempoBuscando = 0f;
    }

    // Update is called once per frame
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

        //busqueda
        tiempoBuscando += Time.deltaTime;
        if(tiempoBuscando >= duracionBusqueda)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoNormal);
            return;
        }


    }
}
