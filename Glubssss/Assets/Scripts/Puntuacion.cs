using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Text textoPuntuacion;
    public int puntosNecesarios = 15;

    private int puntuacion = 0;

    private void Start()
    {
        ActualizarPuntuacion();
    }
    private void ActualizarPuntuacion()
    {
        textoPuntuacion.text = "Puntuación: " + puntuacion + "/15";
    }

    private void OnCollisionEnter2D(Collision2D collision)  //Suma punto y destruye prefab
    {
        if (collision.gameObject.CompareTag("Basura"))
        {
            Debug.Log("Colisión");
            puntuacion++;
            Destroy(collision.gameObject); //Destruye la basura
            ActualizarPuntuacion(); 
            if (puntuacion >= puntosNecesarios)
            {
                Debug.Log("Ganaste");
                //Cambiar escena
            }

        }
    }





}



