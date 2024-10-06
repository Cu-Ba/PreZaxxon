using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawmer : MonoBehaviour
{

    //Declaro los margenes horizontales
    float minX = -35f;
    float maxX = 30f;

    //Declaro los margenes verticales
    float minY = 2f;
    float maxY = 11f;

    //Declaro la posición de Y por defecto (para el PowerUp)
    float defaultY = 6.3f;
    //Declaro la velocidad de desplazamiento
    float speed = 60f;
    //Aqui declaro el numero aleatorio
    float randomX;
    float randomY;

    //Declaro el toggle de Y
    public bool moveInY = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRandomize();
    }

    void SetRandomPosition()
    {
        SetRandomPositionY();
        SetRandomPositionX();
    }

    void SetRandomPositionX()
    {
        randomX = Random.Range(minX, maxX);
    }

    void SetRandomPositionY()
    {
        randomY = Random.Range(minY, maxY);
    }

    public void DisableMovementInY()
    {
        //Aqui al coger un power up secreto el movimiento en y se desactiva volviendo al default
        moveInY = false;
    }
    // void RandomizeX()
    // {
    //     randomX = Random.Range(minX, maxX);
    //     Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
    //     transform.position = newPosition;
    // }

    void UpdateRandomize()
    {
        //Aqui condiciono de la siguiente manera: Si moveInY es true; entonces targetY será igual a randomY if not, sera igual a defaultY
        float targetY = moveInY ? randomY : defaultY;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(randomX, targetY, transform.position.z), speed * Time.deltaTime);
        if (transform.position.x == randomX)
        {
            SetRandomPositionX();
        }
        
        if (moveInY && transform.position.y == randomY)
        {
            SetRandomPositionY();
        }
    }

    // void RandomizeY()
    // {
    //     randomY = Random.Range(minY, maxY);
    //     Vector3 newPosition = new Vector3(transform.position.x, randomY, transform.position.z);
    //     transform.position = newPosition;
    // }

    // void UpdateRandomizeY()
    // {
    //     transform.position = Vector3.Move(transform.position, new Vector3(transform.position.x, randomY, transform.positio.z), speed * Time.deltaTime);
    // }

}
