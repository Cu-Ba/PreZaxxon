using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvicibilityPowerUp : MonoBehaviour
{

    public float invecibilityDuration = 5f;

    private PlayerManager playerManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerManager>().ActivateInvencibility(10f);
            Destroy(gameObject);
        }

    }

    //IEnumerator ActivateInvencibility()
    //{
    //    playerManager.isInvencible = true;
    //    yield return new WaitForSeconds(invecibilityDuration);
    //    playerManager.isInvencible = false;
    //}

}
