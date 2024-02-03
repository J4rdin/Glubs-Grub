using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPrincipal : MonoBehaviour
{
    public ClienteController cliente;

    void Start()
    {
        if (cliente != null)
        {
            cliente.Responder(0); // Aqui iria la respuesta
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Mostrar el pedido después de hacer clic en la pantalla           
            Temporizador.tiempoRestante = 180f;

            //Aqui se pone lo que pasa despues de tomar nota (creo que se cambia la escena al foostruck)
        }

        cliente.darpropinas();  //Se haría cuando deculeves el pedido

    }
}