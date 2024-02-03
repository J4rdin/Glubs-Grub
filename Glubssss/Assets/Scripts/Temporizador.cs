using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public static float tiempoRestante = 180f;
    public float duracionCoccion = 6f;
    private bool coccionEnCurso = false;
    public Slider sliderCoccion;
    public GameObject Comida;
    [SerializeField]
    float x;
    [SerializeField]
    float y;
    void Start()
    {
        tiempoRestante = duracionCoccion;
        sliderCoccion.maxValue = duracionCoccion;
    }
    void Update()
    {
        tiempoRestante -= Time.deltaTime;
        sliderCoccion.value = duracionCoccion - tiempoRestante;

        if (tiempoRestante <= 0f)
        {
            Comida.transform.position = new Vector3(x, y, 0f);
        }
    }
}
