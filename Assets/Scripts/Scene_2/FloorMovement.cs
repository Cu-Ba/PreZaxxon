using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{   
    PlayerManager playerManager;
    float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        playerManager = GetComponent<PlayerManager>();
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
