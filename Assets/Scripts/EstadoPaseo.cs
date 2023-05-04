using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPaseo: MonoBehaviour
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
       player.velMovimiento = 5f;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Egoista") && enabled)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPerseguido);
        }
    }
 }