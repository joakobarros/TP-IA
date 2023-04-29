using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados: MonoBehaviour
{
    public Estado EstadoNormal;
    public Estado EstadoAlerta;
    public Estado EstadoPersecucion;
    public Estado EstadoInicial;

    public MeshRenderer MeshRendererIndicardor;

    private Estado EstadoActual;

    void Start()
    {
        ActivarEstado(EstadoInicial);
    }

    public void ActivarEstado(Estado nuevoEstado)
    {
        if (EstadoActual != null) EstadoActual.enabled = false;
        EstadoActual = nuevoEstado;
        EstadoActual.enabled = true;

        MeshRendererIndicardor.material.color = EstadoActual.ColorEstado;
    }

}
