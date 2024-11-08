using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public List<Transform> gunPoints;

    //Velocidad de la bala
    public float bulletSpeed = 10f;     //Ni de coña a 20 muy muy lento 40->

    //Distancia maxima de la bala
    public float maxDistance = 3f;      //A 40f para que tenga sentido

    //Tiempo hasta el proximo disparo
    float nextFireTime = 0f;

    //Tiempor ENTRE disparos
    float fireRate = 0.5f;

    //Bool para togglear disparo
    public bool powerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (powerUp)
        {
            Shooting();
        }
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

    public void ActivateAutoFire(float duration)
    {
        StartCoroutine(AutoFireCoroutine(duration));
    }

    IEnumerator AutoFireCoroutine(float duration)
    {
        powerUp = true;
        yield return new WaitForSeconds(duration);
        powerUp = false;
    }
}
