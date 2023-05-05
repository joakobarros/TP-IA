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

    void OnEnable()
    {
        player.velMovimiento = 1900;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag ("Egoista"))
        { 
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPaseo);
            
        }
            
    }
 }