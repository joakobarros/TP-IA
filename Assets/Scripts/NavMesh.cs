using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    [HideInInspector]
    public Transform perseguirObjetivo;

    private NavMeshAgent navMeshAgent;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void ActualizarPuntoDestinoNMA(Vector3 puntoDestino)
    {
        navMeshAgent.destination = puntoDestino;
        navMeshAgent.Resume();
    }

    public void ActualizarPuntoDestinoNavMeshAgent()
    {
        ActualizarPuntoDestinoNMA(perseguirObjetivo.position);
    }

    public void DetenerNMA()
    {
        navMeshAgent.Stop();
    }

    public bool HemosLlegado()
    {
        return navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
    }

}
