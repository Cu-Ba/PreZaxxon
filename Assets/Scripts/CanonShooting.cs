using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public List<Transform> gunPoints;

    //Velocidad de la bala
    public float bulletSpeed = 10f;

    //Distancia maxima de la bala
    public float maxDistance = 3f;

    //Tiempo hasta el proximo disparo
    float nextFireTime = 0f;

    //Tiempor ENTRE disparos
    float fireRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Shooting();
    }

    void Shoot()
    {
        foreach (Transform gunPoint in gunPoints)
        {
            //Aqui creo e instancio la bala
            GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);

            //Aqui le doy direccion y velocidad a la bala
            bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * bulletSpeed;

            //Aqui destruyo la bala tras recorrer una distancia
            Destroy(bullet, maxDistance / bulletSpeed);
        }
    }

    void Shooting()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

}
