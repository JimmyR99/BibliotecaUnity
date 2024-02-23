using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{

    public Transform objectToMove;
    public GameObject Puerta; 
    public Animator laPuerta;
    //public float pos1;
    // Start is called before the first frame update
    public void OnTriggerEnter()
    { 
        //objectToMove.position = objectToMove.position + new VectorPos(0,-1.6,0);
        //ejecuta la animación abrir
        laPuerta.Play("Abrir");
    }


    // Update is called once per frame
    public void OnTriggerExit()
    {
       // objectToMove.position = objectToMove.position + new VectorPos(0,1.6,0);
        //ejecuta la animación cerrar
        laPuerta.Play("Cerrar");
    }
}
