using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDiagonal : MonoBehaviour
{
    public float speedZ = 5f;

    public float oscillationSpeed = 2f;
    public float oscillationWidth = 1f;

    float initialX;
    float initialY;

    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x;
        initialY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        transform.Translate(Vector3.back * speedZ * Time.deltaTime);

        float oscillationX = Mathf.Sin(Time.time * oscillationSpeed) * oscillationWidth;
        float oscillationY = Mathf.Sin(Time.time * oscillationSpeed) * oscillationWidth;

        transform.position = new Vector3(initialX + oscillationX, initialY + oscillationY, transform.position.z);
    }
}
