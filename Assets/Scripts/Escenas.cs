using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escenas : MonoBehaviour
{
    public void escenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void escenaEnd()
    {
        SceneManager.LoadScene("End");
    }
       
}
