using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRestriction : MonoBehaviour
{

    //Declaro la velocidad de movimiento y los metros de margenes en axis
    //float moveSpeed = 20f;
    //float marginX = 10f;
    //float marginY = 8f;
    //float marginZ = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitMovement();
    }


    void LimitMovement()
    {

        //Aqui obtengo la posici�n actual de la nave
        Vector3 position = transform.position;

        //Aqui limito en X
        position.x = Mathf.Clamp(position.x, -40f, 47f);
        //Aqui limito en Y
        position.y = Mathf.Clamp(position.y, 2f, 40f);
        //Aqui limito en Z
        position.z = Mathf.Clamp(position.z, 1.5f, 15f);


        //Aqui aplico la posicion a la nave
        transform.position = position;

    }

}
