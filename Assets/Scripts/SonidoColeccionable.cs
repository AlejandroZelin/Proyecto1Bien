using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoColeccionable : MonoBehaviour
{
    private AudioSource audioSouce;

    [SerializeField] private AudioClip colectar1;
    
    void Start()
    {
        audioSouce = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Personaje"))
        {
            audioSouce.PlayOneShot(colectar1);
        }
    }
}
