using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFirePowerUp : MonoBehaviour
{
    public float autoFireDuration = 15f;

    private CanonShooting canonShooting;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //canonShooting = other.GetComponent<CanonShooting>();
            //StartCoroutine(ActivateAutoFire());
            //Destroy(gameObject);

            other.GetComponent<CanonShooting>().ActivateAutoFire(10f);
            Destroy(gameObject);

        }

  
    }

    IEnumerator ActivateAutoFire()
    {
        Debug.Log("POWER ACTIVO");
        canonShooting.powerUp = true;
        yield return new WaitForSeconds(autoFireDuration);
        canonShooting.powerUp = false;
        Debug.Log("POWER DESACTIVADO");
    }
}
