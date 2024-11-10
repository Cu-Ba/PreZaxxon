using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerUp : MonoBehaviour
{
    //Velocidad de rotación
    float rotationSpeed = 150f;

    //Velocidad de movimiento
    float moveSpeed = 30f;
    public Transform nave;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotar();
        Moverse();
    }

    void Rotar()
    {
        transform.Rotate (Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }

    void Moverse()
    {
        //Vector3 direction = (nave.position - transform.position).normalized;      //Esto era para que el power Up fuera al jugador, pero queda raro
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
    }

}
