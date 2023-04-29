using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoNormal: MonoBehaviour
{
    public Transform[] WayPoints;

    private NavMesh navMesh;
    private int siguienteWayPoint;

    void Awake()
    {
        navMesh = GetComponent<NavMesh>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnabled()
    {
        navMesh.ActualizarPuntoDestinoNMA(WayPoints[siguienteWayPoint].position);
    }
}
