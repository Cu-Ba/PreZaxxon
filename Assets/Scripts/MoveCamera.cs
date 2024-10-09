using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //decla las variables de las que tomaré los inputs dela nave
    public Transform player;        //Declaro una variable publica donde ira un transform el ucla psoteriormente se llamará nave (Aqui va el transform de la nave desde Unity)
    public Vector3 offset;          //Esto es un offset que configuraré con un vector en unity en el axis Z
    //Declaro la variables de los parametros para suavizar y driftear la camara
    public float smoothspeed = 0.125f;
    public float driftIntensity = 0.2f;         //Valor de drift !!CUANTO SE MUEVE LA NAVE DE MANERA IMPREDECIBLE!! no cuan SUAVE

    Vector3 velocity = Vector3.zero;
    bool isDrifting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate se llama despues de que el Update se llama
    void LateUpdate()
    {
    
    CameraMovement();
        
    }

    public void CameraMovement()
    {
        Vector3 targetPosition = player.position + offset; //Posicion absoluta de la camara detras del jugador, el argumento target bloquea algo en este caso la posicion del jugador mas un offste

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothspeed); //El metodo SmoothDamp recibe 4 argumentos (1. posicion actual 2. posicion objetivo 3.velocidad de suavizado 4. velocidad del punto A al punto B)

        if (isDrifting)
        {

            smoothedPosition += Random.insideUnitSphere * driftIntensity; //Esto no se que es, se supone que aplica drift, insideUnitSphere se mueve en todas las direcciones en una esfera de radio 1 

        }

        transform.position = smoothedPosition;
    }

    public void ActivateDrift()
    {
        StartCoroutine(DriftDuration());
    }

    IEnumerator DriftDuration()
    {
        isDrifting = true;
        yield return new WaitForSeconds(0.5f);
        isDrifting = false;
    }
}
