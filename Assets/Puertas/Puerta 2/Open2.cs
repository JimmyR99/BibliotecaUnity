using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open2 : MonoBehaviour
{
    public Animator laPuerta;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        //ejecuta la animación abrir
        laPuerta.Play("Abrir");
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        //ejecuta la animación cerrar
        laPuerta.Play("Cerrar");
    }
}
