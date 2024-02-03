using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingredient : MonoBehaviour
{
    public GameObject Bread;
    public GameObject Convo;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ingrediente"))
        {
            Debug.Log("Colision");
            Instantiate(Convo);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
