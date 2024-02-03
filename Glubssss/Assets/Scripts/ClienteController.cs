using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClienteController : MonoBehaviour
{
    public Text textoBocadillo;  
    public Button botonRespuesta1;
    public Button botonRespuesta2;
    public Button botonRespuesta3;

    public string fraseInicial;
    public string respuestaCorrecta;
    public string respuestaIncorrecta1;
    public string respuestaIncorrecta2;

    public int estadocliente;  // 1.Feliz 2.Normal 3.Enfadado
    public int dinero = 0;
    public int propinas;

    void Start()
    {
        MostrarBocadillo(fraseInicial);  //La frase se pone en el editor
        estadocliente = Random.Range(1, 4); //Establece de manera aleatoria el estado del cliente
    }

    void MostrarBocadillo(string texto)
    {
        textoBocadillo.text = texto;
        Botones(true);
    }

    public void Responder(int opcion)
    {
        string respuesta = "";  //creamos el string respuesta

        switch (opcion)  //con esto determinamos la repuesta que es y lo que pasa
        {
            case 1:
                respuesta = respuestaCorrecta;
                if (estadocliente == 1) //Si ya esta feliz se queda feliz si no pues le suma un estado de ánimo
                {
                    estadocliente = 1;
                }
                else
                {
                    estadocliente--;
                }
                break;

            case 2:
                respuesta = respuestaIncorrecta1;
                if (estadocliente == 3) //Si ya esta enfadado se queda enfadado si no pues le resta un estado de ánimo
                {
                    estadocliente = 3;
                }
                else
                {
                    estadocliente++;
                }
                break;
            case 3:
                respuesta = respuestaIncorrecta2;
                if (estadocliente == 3) 
                {
                    estadocliente = 3;
                }
                else
                {
                    estadocliente++;
                }
                break;
        }

        MostrarBocadillo(respuesta);

        // Desactivar los botones después de la respuesta
        Botones(false);
    }

    public void darpropinas()  //Puntuacion
    {
        if (estadocliente == 1) //Feliz
        {
            propinas = Random.Range(4, 10);
            Player.puntuacion += propinas;
        }
        if (estadocliente == 2) //Normal
        {
            propinas = Random.Range(2, 5);
            Player.puntuacion += propinas;
        }
        if (estadocliente == 3) //Enfadado
        {
            propinas = Random.Range(0, 2);
            Player.puntuacion += propinas;
        }
    }
    void Botones(bool active)
    {
        botonRespuesta1.gameObject.SetActive(active);
        botonRespuesta2.gameObject.SetActive(active);
        botonRespuesta3.gameObject.SetActive(active);
    }
}
