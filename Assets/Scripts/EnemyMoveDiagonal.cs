using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDiagonal : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        transform.Translate(new Vector3(-1, -1, 0).normalized * speed * Time.deltaTime);
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
