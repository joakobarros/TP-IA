using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{

    protected MaquinaDeEstados maquinaDeEstados;
    //protected es comop private con la diferencia que lo pueden utilizar las clases que ereden de donde este definida, en este caso Estado

    protected virtual void Awake()
    {
       // Debug.Log("ADios");
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
    }
}
