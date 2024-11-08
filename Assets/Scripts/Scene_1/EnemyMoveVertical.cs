using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveVertical : MonoBehaviour
{
    public float speedZ = 5f;

    public float oscillationSpeed = 2f;
    public float oscillationWidth = 3f;

    float initialY;

    // Start is called before the first frame update
    void Start()
    {
        initialY = transform.position.y;    
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        transform.Translate(Vector3.back * speedZ * Time.deltaTime);

        float oscillation = Mathf.Sin(Time.time * oscillationSpeed) * oscillationWidth;
        transform.position = new Vector3(transform.position.x, initialY + oscillation, transform.position.z);

    }
}
