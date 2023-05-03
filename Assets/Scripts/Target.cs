using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public GameObject cubo1; 
    public GameObject cubo2;

    private void Start()
    {
        cubo1.GetComponent<Renderer>().material.color = Color.red;
        cubo2.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cubo1.GetComponent<Renderer>().material.color = Color.green;
            cubo2.GetComponent<Renderer>().material.color = Color.green;
        }


    }

}
