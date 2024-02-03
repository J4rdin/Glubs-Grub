using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasura : MonoBehaviour
{
    public float velocidad = 2.0f;

    private bool siendoArrastrado = false;
    private bool sePuedeMover = true;
    

    private void Update()
    {
        if (sePuedeMover)
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }
    }
    private void OnMouseDown()
    {
        sePuedeMover = false;
    }


    public void SetSiendoArrastrado(bool arrastrando)
    {
        siendoArrastrado = arrastrando;
    }

}





