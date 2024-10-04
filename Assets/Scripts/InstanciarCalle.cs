using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarCalle : MonoBehaviour
{
    [SerializeField] GameObject calle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoverSuelo");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator MoverSuelo()
    {
        while (true)
        {
            Instantiate(calle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(20f);
        }
    }
}