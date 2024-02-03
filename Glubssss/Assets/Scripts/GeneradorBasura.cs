using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBasura : MonoBehaviour
{
    public GameObject[] tiposDeBasura;  // Array con los diferentes tipos de basura
    public Transform puntoGeneracion;  // Punto en el río donde se generará la basura
    public float tiempoEntreGeneracion = 2.0f;

    private void Start()
    {
        InvokeRepeating("GenerarBasura", 0, tiempoEntreGeneracion);
    }

    private void GenerarBasura()
    {
        int indiceBasura = Random.Range(0, tiposDeBasura.Length);
        GameObject nuevaBasura = Instantiate(tiposDeBasura[indiceBasura], puntoGeneracion.position, Quaternion.identity);
    }
}
