using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveHorizontal : MonoBehaviour
{
    public float speedZ = 5f;

    //Atento a esta fumada, vamos a crear una oscilacion sinusoidal, en la que declararemos la velocidad de movimiento entre la izquierda y derecha, así como un radio de movimiento (el resto de movimientos para otros spikes es el mismo que este)

    public float oscillationSpeed = 2f;
    public float oscillationWidth = 3f;

    float initialX; 

    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        // Aqui declaro el movimiento del obstaculo hacia el jugador
        transform.Translate(Vector3.back * speedZ * Time.deltaTime);

        //Aqui es donde viene el turron, movimientos oscilantes en el eje X
        float oscillation = Mathf.Sin(Time.time * oscillationSpeed) * oscillationWidth;
        transform.position = new Vector3(initialX + oscillation, transform.position.y, transform.position.z);
    }
}
