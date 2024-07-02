using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
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
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0, velocidadZ * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidadZ * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotacionY * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotacionY * Time.deltaTime, 0);
        }


    }
}
