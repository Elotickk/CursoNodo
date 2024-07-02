using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : MonoBehaviour
{
    public float velocidad;
    public Animator animator;

    private float inputX;
    private float inputZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animaciones();

        Controles();
    }

    void Animaciones()
    {   
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("jump");
        }

        if (inputZ < 0 || inputZ > 0 || inputX < 0 || inputX > 0)
        {
            if (Input.GetKey(KeyCode.C))
            {
                animator.SetInteger("estados", 3);
            }
            else
            {
                animator.SetInteger("estados", 1);
            }
        }
        else
        {
            if(Input.GetKey(KeyCode.C))
            {
                animator.SetInteger("estados", 2);
            }
            else
            {
                animator.SetInteger("estados", 0);
            }
        }
    }

    void Controles()
    {
        inputX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        inputZ = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;

        transform.Translate(inputX, 0, inputZ);
    }
}
