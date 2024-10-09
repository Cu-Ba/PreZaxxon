using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArray : MonoBehaviour
{
    //Aqui creo el array para los enemigos
    public GameObject[] spikes;
    public Transform[] spawmPoints;

    //Aqui declaro el tiempo entre cada spawm
    public float spawmTime = 4f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawmEnemies());
    }

    IEnumerator SpawmEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawmTime);

            Debug.Log("Spawming enemy...");

            //Aqui es donde viene la magia, escojo un enemigo aleatorio y un punto de spawm aleatorio
            int randomEnemyIndex = Random.Range(0, spikes.Length);
            int randomSpawmPointIndex = Random.Range(0, spawmPoints.Length);

            //Aqui es donde lo instancio como tal
            Instantiate(spikes[randomEnemyIndex], spawmPoints[randomSpawmPointIndex].position, Quaternion.identity);
        }
    }
}
