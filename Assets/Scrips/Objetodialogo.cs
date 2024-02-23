using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetodialogo : MonoBehaviour
{
    public GameObject dialogBox; // Este es el objeto de diálogo que se abrirá al hacer clic en el botón.

    void OnMouseDown () {
     dialogBox.SetActive(true);
     // Activa el objeto de diálogo al hacer clic en el botón.
    }
}
