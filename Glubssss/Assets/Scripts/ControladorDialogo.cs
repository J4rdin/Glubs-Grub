using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDialogo : MonoBehaviour
{
    public Text textoDialogo;
    public string[] lineasDialogo;
    public Button[] botonesRespuesta;
    public GameObject panel;
    private int indiceLinea = 0;

    int panes = 0;
    int carnes = 0;
    int toppings = 0;
    int salsas = 0;

    public RawImage img_panes;
    public RawImage img_carnes;
    public RawImage img_toppings;
    public RawImage img_salsas;

    public RawImage img_estadoanimo;
    int estado_animo = 0;

    bool dialogo_ended = false;

    public static string pedido = "";       //Pan - Carne - Salsa - Topping
   
    public int propinas = 3;
    public int dinero = 0;

    public int neutrochoice = 0;
    bool pedido_entregable = false;



    void Start()
    {       
        GenerarEstado();  //Estados de animo
        ActivarImagenPedido(false);  //Desactivar las imágenes al principio
        ActivarBotonesRespuesta(false);  // Desactivar los botones al principio
        MostrarSiguienteLinea();                
        neutrochoice = Random.Range(0, 2); // 0 = Enfadado , 1 = Feliz      
    }

    void Update()
    {      
        // Detectar clic del mouse
        if (Input.GetMouseButtonDown(0) && dialogo_ended == false)
        {
            MostrarSiguienteLinea();
        }
      
    }
  
    void MostrarSiguienteLinea()
    {
        if (indiceLinea < lineasDialogo.Length) //Muestra dialogo hasta el final
        {
            textoDialogo.text = lineasDialogo[indiceLinea];
            indiceLinea++;           
        }
        else
        {
            ActivarBotonesRespuesta(true);  // Activar botones al final del diálogo            
        }
    }

    public void DarPedido()
    { 
        if (pedido_entregable == true)
        {
            StartCoroutine(ActivarPanel());
            if (Player.item == pedido && pedido_entregable == true)
            {
                print("Bien????");
                textoDialogo.text = "¡Muchas gracias!"; //Lo que dice al darle el pedido bien
                dinero = dinero + 10 + propinas;
            }
            if (Player.item != pedido && pedido_entregable == true)
            {
                print("MAl????");
                textoDialogo.text = "¡No es lo que he pedido chico!"; //Lo que dice al darle el pedido mal                
                
               
            }

        }
        
    }

    IEnumerator ActivarPanel()
    {
        panel.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        panel.gameObject.SetActive(false);
    }
    public void SeleccionarRespuesta(int respuestaIndex)
    {
        // Lógica para cada respuesta
        
        switch (respuestaIndex)
        {
            case 0:
                // Acciones para la primera respuesta /Enfadado
                print("Opcion 1");

                if (estado_animo == 3) //Si elige enfadado
                {
                    propinas *= 2;
                }    
                if (estado_animo == 2 && neutrochoice == 0) //Neutro elige enfadado
                {
                    propinas *= 4;
                }
                if (estado_animo == 1) //Si elige feliz
                {
                    propinas = 0;
                }

                break;
            case 1:
                // Acciones para la segunda respuesta /Neutro
                print("Opcion 2");              
               
                break;
            case 2:
                // Acciones para la tercera respuesta /Feliz
                print("Opcion 3");

                if (estado_animo == 1) //Si elige feliz
                {
                    propinas *= 2;
                }
                if (estado_animo == 2 && neutrochoice == 1) //Neutro elige feliz
                {
                    propinas *= 4;
                }
                if(estado_animo == 3) //Si elige triste
                {
                    propinas = 0;
                }
                break;
        }

        CerrarDialogo();
        dialogo_ended = true;
        GenerarPedido();
    } 

    void CerrarDialogo()
    {
        ActivarBotonesRespuesta(false);  // Desactivar botones al cerrar el diálogo
        ActivarImagenPedido(true); //Activar imagenes
        panel.gameObject.SetActive(false);
        print("Fin dialogo");
    }

    void ActivarBotonesRespuesta(bool activar)
    {
        foreach (Button boton in botonesRespuesta)
        {
            boton.gameObject.SetActive(activar);
        }
    }

    void ActivarImagenPedido(bool activar)
    {
        img_panes.gameObject.SetActive(activar);
        img_carnes.gameObject.SetActive(activar);
        img_toppings.gameObject.SetActive(activar);
        img_salsas.gameObject.SetActive(activar);    
    }

    void GenerarPedido()
    {
        panes = 1;
        carnes = Random.Range(1, 3);
        toppings = Random.Range(1, 3);
        salsas = Random.Range(1, 3);

        switch (panes)  //Añadir panes
        {
            case 1:
                img_panes.texture = Resources.Load<Texture>("Panes1");  
                print("Pan 1");
                pedido += "1";
                break;           
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (carnes)
        {
            case 1:
                img_carnes.texture = Resources.Load<Texture>("Carnes1");
                print("Carne 1");
                pedido += "1";
                break;
            case 2:
                img_carnes.texture = Resources.Load<Texture>("Carnes2");
                print("Carne 2");
                pedido += "2";
                break;         
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (salsas)
        {
            case 1:
                img_salsas.texture = Resources.Load<Texture>("Salsas1");
                print("Salsas 1");
                pedido += "1";
                break;
            case 2:
                img_salsas.texture = Resources.Load<Texture>("Salsas2");
                print("Salsas 2");
                pedido += "2";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (toppings)
        {
            case 1:
                img_toppings.texture = Resources.Load<Texture>("Toppings1");
                print("Toppings 1");
                pedido += "1";
                break;
            case 2:
                img_toppings.texture = Resources.Load<Texture>("Toppings2");
                print("Toppings 2");
                pedido += "2";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

       
        print(pedido);
        pedido_entregable = true;
 
    }

    void GenerarEstado()
    {
        estado_animo = Random.Range(1, 4); //Estados animo
        img_estadoanimo.gameObject.SetActive(true);

        switch (estado_animo)
        {
            case 1:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado1");  //Feliz
                print("Feliz");
                break;
            case 2:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado2");  //Neutro
                print("Neutro");
                break;
            case 3:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado3");  //Enfadado
                print("Enfadado");
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }
    }

   
}
