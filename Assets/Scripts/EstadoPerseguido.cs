using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPerseguido: MonoBehaviour
{
    private MaquinaDeEstadosPlayer maquinaDeEstados;   

    private Player player;

    void Awake()
    {
        maquinaDeEstados = GetComponent<MaquinaDeEstadosPlayer>();
        player = GetComponent<Player>();
    }

   void OnEnabled()
    {
       player.velMovimiento = 7f;
    }

    public void OnTriggerExit()
    {
        maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPaseo);
    }
 }