using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClienteAppear : MonoBehaviour
{
    public Transform puntoFinal; // Punto final donde el objeto debe detenerse
    public float velocidad = 2f; // Velocidad de movimiento del objeto
    public float velocidadOpacidad = 0.5f; // Velocidad de cambio de opacidad
    public float opacidadFinal = 1f; // Opacidad final del objeto
    public bool activarTransicion = true; // Variable para activar/desactivar la transición

    private SpriteRenderer spriteRenderer;
    private Color colorInicial;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorInicial = spriteRenderer.color;
        spriteRenderer.color = new Color(colorInicial.r, colorInicial.g, colorInicial.b, 0f); // Inicialmente el objeto es transparente
    }

    void Update()
    {
        if (activarTransicion)
        {
            // Movimiento del objeto hacia el punto final
            transform.position = Vector3.MoveTowards(transform.position, puntoFinal.position, velocidad * Time.deltaTime);

            // Cambio de opacidad gradual
            float opacidadActual = spriteRenderer.color.a;
            float nuevaOpacidad = Mathf.MoveTowards(opacidadActual, opacidadFinal, velocidadOpacidad * Time.deltaTime);
            spriteRenderer.color = new Color(colorInicial.r, colorInicial.g, colorInicial.b, nuevaOpacidad);

            // Detener la transición cuando el objeto llegue al punto final y alcance la opacidad final
            if (transform.position == puntoFinal.position && Mathf.Approximately(opacidadActual, opacidadFinal))
            {
                activarTransicion = false;
            }
        }
    }
}
