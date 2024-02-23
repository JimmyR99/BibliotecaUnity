using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour
{
    public Transform Target;
    public GameObject Player;
    // Start is called before the first frame update
    private void OnTriggerEnter()
    {
        Player.transform.position = Target.transform.position;
    }

}
