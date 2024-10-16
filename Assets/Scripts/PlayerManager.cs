using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Accedo al script de la camara para poder aplicar un drift
    public MoveCamera cameraFollow;

    //Aqui creo un float para la salud del jugador (Aun sin uso)
    public float health = 10f;
    bool alive = true;

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
    float maxRotationAngle = 10f;

    //Power Up
    public bool isInvencible = false;
    //Trigger se llama cuando coliciona con otro
    void OnTriggerEnter(Collider other)
    {
        if (isInvencible == false)
        {
            TakeDamage(other);
            DestroyObstacle(other);
        }

        else
        {
            DestroyObstacle(other);
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
        if (isInvencible)
        {

        }
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

    void TakeDamage(Collider other)
    {
        if (alive)
        {
            if (other.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Capitan, impacto de asteroide!!");
                cameraFollow.ActivateDrift();
                health -= 1f;
                Debug.Log("Salud actual: " + health);
            }

            else if (other.gameObject.CompareTag("Spike"))
            {
                Debug.Log("Impacto de Spike!!");
                cameraFollow.ActivateDrift();
                health -= 2f;
                Debug.Log("Salud actual: " + health);

            }

            if (health <= 0f)
            {
                alive = false;
                Die();
            }
        }
    }

    void IsAlive()
    {
        if (health > 0f)
        {
            alive = true;
        }
        else if (health < 0f)
        {
            alive = false;
        }
    }

    void Die()
    {
            Debug.Log("MUERTE");
    }

    void DestroyObstacle(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
        }
    }

    public void ActivateInvencibility(float duration)
    {
        StartCoroutine(InvencibilityCoroutine(duration));
    }

    IEnumerator InvencibilityCoroutine(float duration)
    {
        isInvencible = true;
        yield return new WaitForSeconds(duration);
        isInvencible = false;
    }
}
