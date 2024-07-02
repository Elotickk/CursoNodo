using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public float velocidadX = 0;
    public float velocidadY = 0;
    public float velocidadZ = 0;
    //Rotacion
    public float rotacionX = 0;
    public float rotacionY = 0;
    public float rotacionZ = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);

        transform.Rotate(rotacionX * Time.deltaTime, rotacionY * Time.deltaTime, rotacionZ * Time.deltaTime);
    }
}
