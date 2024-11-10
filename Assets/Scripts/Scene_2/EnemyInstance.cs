using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstance : MonoBehaviour
{
    //Instancia del obstaculo
    [SerializeField] GameObject obstacle;
    [SerializeField] GameObject[] powerUp;

    public float spawnRate = 0.4f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("CrearEnemigo");
        StartCoroutine("RiseDificulty");


    }

    // Update is called once per frame
    void Update()
    {

        TrySpawnPowerUp();
        
    }

    IEnumerator CrearEnemigo()
    {
        while (true)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }

    }

    IEnumerator RiseDificulty()
    {
        while (spawnRate > 0.1f)
        {
            yield return new WaitForSeconds(30f);
            spawnRate -= 0.1f;
        }
    }

    void TrySpawnPowerUp()
    {
        int randomChance = Random.Range(0, 1501);
        if (randomChance == 47)
        {
            SpawnPowerUp();
        }
    }

    void SpawnPowerUp()
    {
        int n = Random.Range(0, powerUp.Length);
        Instantiate(powerUp[n], transform.position, Quaternion.identity);
    }

}
