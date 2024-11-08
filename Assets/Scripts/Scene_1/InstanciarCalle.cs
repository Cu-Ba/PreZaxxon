using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarCalle : MonoBehaviour
{
    //De aqui sacare las instancias de la calle asi como la posicion del jugador
    public GameObject callePrefab;
    public Transform player;

    //Longitud de la seccion del terreno
    float calleLenght = 700f;

    private Vector3 nextSpawmPosition;

    bool canSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawmPosition = transform.position + new Vector3(0, 0, calleLenght);          //Ojo, segun entiendo, lo que le digo aqui es vete 30 metros en Z hacia atras (que es lo que mide el terreno) y generate
    }                                                                                     //con lo que deberia generarse exactamente detras del terreno generado, creando un loop infinito de terrenos !!EN TEORIA!!

    // Update is called once per frame
    void Update()
    {
        ComprobarPosicionJugador();
    }

    void ComprobarPosicionJugador()
    {

        if (canSpawn && transform.position.z <= player.position.z) 
        {
            canSpawn = false;

            SpawmNextSection();

            StartCoroutine(DestroyCalle());
        }
    }

    void SpawmNextSection()
    {
        
        Instantiate(callePrefab, nextSpawmPosition, Quaternion.identity);

        nextSpawmPosition += new Vector3(0, 0, calleLenght);

        canSpawn = true;
    }

    IEnumerator DestroyCalle()
    {
        yield return new WaitForSeconds(5f);

        Destroy(gameObject);
    }
}
