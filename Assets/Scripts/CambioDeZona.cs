using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeZona : MonoBehaviour
{
    public AudioSource emisor;

    public AudioClip MusicaDefault;
    public AudioClip Ascensor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            emisor.Stop();
            emisor.clip = Ascensor;
            emisor.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            emisor.Stop();
            emisor.clip = MusicaDefault;
            emisor.Play();
        }
    }

}
