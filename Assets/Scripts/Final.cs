using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEditor.VersionControl;

public class Final : MonoBehaviour
{
    public TMP_Text TextFinal;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        
    }
    
    void Update()
    {
        if (gameManager.EsFinal())
        {
            TextFinal.text = "Juego Finalizado.";
            TextFinal.gameObject.SetActive(true);
            
            Time.timeScale = 0;
        }
        TextFinal.text = "Juego Finalizado.";
    }
}
