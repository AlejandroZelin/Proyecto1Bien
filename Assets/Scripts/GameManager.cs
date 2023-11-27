using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool finalJuego = false;

    public bool EsFinal()
    {
        return finalJuego;
    }    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Final()
    {
        finalJuego = true;
    }
}
