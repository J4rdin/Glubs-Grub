using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float velocidadOriginal;
    [SerializeField]
    float velocidad;
    [SerializeField]
    float slowPuddle;
    public static string item = "0000";
    public static int puntuacion = 0;
    //1000 = PanTaco 1100 = PanTaco con Ojos
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovimientoLateral();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Puddle")
        {
            velocidad = slowPuddle;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        velocidad = velocidadOriginal;
    }

        void MovimientoLateral()
    {
        if (Input.GetKey(KeyCode.W) && WorkStation.entered == false)
        {
            rb.velocity += new Vector2(0, velocidad);
        }
        if (Input.GetKey(KeyCode.A) && WorkStation.entered == false)
        {
            rb.velocity += new Vector2(-velocidad, 0);
        }
        if (Input.GetKey(KeyCode.S) && WorkStation.entered == false)
        {
            rb.velocity += new Vector2(0, -velocidad);
        }
        if (Input.GetKey(KeyCode.D) && WorkStation.entered == false)
        {
            rb.velocity += new Vector2(velocidad, 0);
        }
    }

    public void DestroyPuddle()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag("Puddle");

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
