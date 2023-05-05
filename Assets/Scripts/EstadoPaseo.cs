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

    void OnEnable()
    {
        player.velMovimiento = 1200;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Egoista"))
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPerseguido);
        }
    }
 }