using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstance : MonoBehaviour
{
    //Instancia del obstaculo
    [SerializeField] GameObject obstacle;


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("CrearEnemigo");
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    IEnumerator CrearEnemigo()
    {
        while (true)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
        }

        //Destroy(GameObject obstacle, WaitForSeconds(4f);

    }

}
