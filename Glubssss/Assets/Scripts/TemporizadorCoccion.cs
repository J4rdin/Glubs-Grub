using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemporizadorCoccion : MonoBehaviour
{
    public Slider sliderCoccion;
    public float duracionCoccion = 6f;
    private float tiempoRestante;
    private bool coccionEnCurso = false;

    [SerializeField]
    float x;
    [SerializeField]
    float y;

    public GameObject carne1;
    public GameObject Food;

    void Start()
    {
        tiempoRestante = duracionCoccion;
        sliderCoccion.maxValue = duracionCoccion;
    }

    void Update()
    {
        if (coccionEnCurso && sliderCoccion.value < duracionCoccion)
        {
            tiempoRestante -= Time.deltaTime;
            sliderCoccion.value = duracionCoccion - tiempoRestante;

            if (tiempoRestante <= 0f)
            {
                // Cocción completa
                //Cambia animacion del sprite                
                carne1.transform.position = new Vector3(x, y, 0f);
                if (Food.CompareTag("1000"))
                {
                    Player.item = FoodID.PanTaco;
                    print(Player.item);
                }

                if (Food.CompareTag("0100"))
                {
                    Player.item = FoodID.Ojo;
                }

                if (Food.CompareTag("0200"))
                {
                    Player.item = FoodID.Gusanos;
                }

                coccionEnCurso = false;
                Debug.Log("Cocción completa");
                ReiniciarTemporizador();
            }
        }
    }

    public void IniciarTemporizador()
    {
        coccionEnCurso = true;
    }

    void ReiniciarTemporizador()
    {
        tiempoRestante = duracionCoccion;
        sliderCoccion.value = 0f;
        coccionEnCurso = false;
    }
}


