using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstadosPlayer: MonoBehaviour
{
    public MonoBehaviour EstadoPaseo;
    public MonoBehaviour EstadoPerseguido;
    public MonoBehaviour EstadoInicial;

    private MonoBehaviour EstadoActual;

    void Start()
    {
        ActivarEstado(EstadoInicial);
    }

    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if (EstadoActual != null) EstadoActual.enabled = false;
        EstadoActual = nuevoEstado;
        EstadoActual.enabled = true;

    }

}