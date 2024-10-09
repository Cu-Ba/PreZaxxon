using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Accedo al script de la camara para poder aplicar un drift
    public MoveCamera cameraFollow;
    //Accedo al obstaculo para poder destruirlo
    //Ejes de movimiento
    float moveX;
    float moveY;
    float moveZ;

    //Eje de rotacion
    float rotation;

    //Velocidad de desplazamientos
    public float moveSpeed = 20f;
    public float rotationSpeed;
    public float speed = 50f;

    //Angulo de maxima rotacion
    float maxRotationAngle = 5f;

    //Trigger se llama cuando coliciona con otro
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Capitan, hemos impactado!!");
            cameraFollow.ActivateDrift();
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer() 
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        moveY = Input.GetAxis("Depth");

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * moveX, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * moveZ, Space.World);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * moveY, Space.World);
    }

    void RotatePlayer()
    {
        //rotation = Input.GetAxis("Rotate");


        transform.rotation = Quaternion.Euler(maxRotationAngle * -moveX, -90f, maxRotationAngle * -moveY);
    }

}
