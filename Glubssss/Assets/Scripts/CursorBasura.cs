using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBasura : MonoBehaviour
{
    private bool arrastrando = false;
    private Transform objetoArrastrado;
    private Vector3 offset;

    private void Update()
    {
        if (arrastrando)
        {
            Vector3 posicionCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objetoArrastrado.position = new Vector3(posicionCursor.x + offset.x, posicionCursor.y + offset.y, 0f);

            if (Input.GetMouseButtonUp(0))
            {
                objetoArrastrado.GetComponent<MovimientoBasura>().SetSiendoArrastrado(false);
                objetoArrastrado = null;
                arrastrando = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!arrastrando)
        {
            objetoArrastrado = transform;
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objetoArrastrado.GetComponent<MovimientoBasura>().SetSiendoArrastrado(true);
            arrastrando = true;
        }
    }
}



