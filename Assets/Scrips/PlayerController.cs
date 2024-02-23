using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variable movimiento horizontal
    public float horizontalmove;
    //variable movimiento vertical
    public float verticalmove;
    //identifica quien va a ser el jugador
    public CharacterController player;
    //variable velocidad jugador
    public float playerSpeed;
    // primer bucle, se ejecuta cuando inicia el script
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    //velocidad del jugador por frame
    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");
    }
    // fisicas del jugador
    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontalmove,0,verticalmove));
    }
}
