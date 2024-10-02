using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    //Asigno velocidad local
    float localSpeed;
    //Accedo al componente del jugador
    PlayerManager playerManager;


    // Start is called before the first frame update
    void Start()
    {

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerManager = player.GetComponent<PlayerManager> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        localSpeed = playerManager.speed;
        transform.Translate(Vector3.back * Time.deltaTime * localSpeed);
    }
}
