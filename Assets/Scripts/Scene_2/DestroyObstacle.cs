using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{

    [SerializeField] GameObject nave;
    public float destroyPosition = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < destroyPosition)
        {
            Destroy(gameObject);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {

        //Aqui verifico si el colisionante es una bala
        if (other.CompareTag("Bullet"))
        {
            //Aqui destruyo el objeto
            Destroy(gameObject);
            //Aqui destruyo la bala
            Destroy(other.gameObject);

            ScoreManager.Instance.Score += 10;
            //Aqui reproduzco la animaci�n de explosion --!!!!!PENDIENTE DE ANIMAR!!!!!--
        }

    }
}
