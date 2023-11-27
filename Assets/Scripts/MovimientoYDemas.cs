using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class MovimientoYDemas : MonoBehaviour
{
    public float magnitudVelocidad = 2;
    Rigidbody2D fisicas;
    private bool detener = false;
    private float tiempoDetenido = 2.0f;
    private float tiempoColision;
    private Color colorOriginal;
    SpriteRenderer sprite;
    private GameManager gameManager;
    

    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        colorOriginal = sprite.color;
    }

    void Update()
    {
        if (detener && Time.time - tiempoColision >= tiempoDetenido)
        {
            Resetcolor();
            detener = false;
        }

        if (!detener)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");
            Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);

            fisicas.velocity = movimiento * magnitudVelocidad;
        }
        else
        {
            fisicas.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            sprite.color = Color.red;
            detener = true;
            tiempoColision = Time.time;
        }

        if (collision.gameObject.CompareTag("Escala"))
        {
            transform.localScale = new Vector2(0.3f, 0.3f);
        }

            if (collision.gameObject.CompareTag("Final"))
        {
            
            gameManager.Final();
        }
    }

    private void Resetcolor()
    {
        sprite.color = colorOriginal;
    }
}