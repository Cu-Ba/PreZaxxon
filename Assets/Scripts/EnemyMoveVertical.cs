using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveVertical : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }
}
