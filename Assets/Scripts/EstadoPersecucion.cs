using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPersecucion : Estado
{

    
    private NavMesh navMesh;
    private Vision vision;

    protected virtual void Awake()
    {
        base.Awake();
        navMesh = GetComponent<NavMesh>();
        vision = GetComponent<Vision>();

    }

    void Update()
    {
        RaycastHit hit;
        if(!vision.verAlJugador(out hit, true))
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
            return;
        }

        navMesh.ActualizarPuntoDestinoNMA();
    }
}
