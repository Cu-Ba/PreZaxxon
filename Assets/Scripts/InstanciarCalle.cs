using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarCalle : MonoBehaviour
{
    //De aqui sacare las instancias de la calle asi como la posicion del jugador
    public GameObject callePrefab;
    public Transform player;

    //Longitud de la seccion del terreno
    float calleLenght = 5f;

    Vector3 nextSpawmPosition;

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
        Debug.Log("Player Z position: " + player.position.z);
        Debug.Log("Next Spawm Position: " + nextSpawmPosition.z);

        if (player.position.z >= nextSpawmPosition.z - calleLenght)
        {
            SpawmNextSection();
            
        }
    }

    void SpawmNextSection()
    {
        Debug.Log("Nuevo escenario...");
        
        Instantiate(callePrefab, nextSpawmPosition, Quaternion.identity);

        nextSpawmPosition += new Vector3(0, 0, calleLenght);
    }
}
