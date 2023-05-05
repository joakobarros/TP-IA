using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private Escenas escenas;
    public float velMovimiento;
    public int contar;

    public Vector2 sensibilidad;

    void Start()
    {
        contar = 0;
        rigidbody = GetComponent<Rigidbody>();
        escenas = GetComponent<Escenas>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    public void Update()
    {      
        Movimiento();
        Camara();

        if (contar == 3)
        {
            AudioSource audios = FindObjectOfType<AudioSource>();
            audios.Pause();
            escenas.escenaEnd();

        }

    }

    public void Movimiento()
    {    
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (hor != 0 || ver != 0)
        {
            Vector3 direction = (transform.forward * ver + transform.right * hor).normalized;

            rigidbody.velocity = direction * velMovimiento * Time.deltaTime;
        }
    }

    private void Camara()
    {
        if(contar < 3)
        {
            float hor = Input.GetAxis("Mouse X");
            float ver = Input.GetAxis("Mouse Y");

            if (hor != 0)
            {
                transform.Rotate(0, hor * sensibilidad.x, 0);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Arco")
        {
            contar += 1;
        }
    }

}
