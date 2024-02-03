using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Playgame()
    {
        SceneManager.LoadScene("FoodTruckTopDown");
    }

    public void GoOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void GoPause()
    {
        SceneManager.LoadScene("Pause");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoBackMeat()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Meat");
        if(Player.item != "0000")
            DestroyFood();
    }
    public void GoBackBread()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Bread");
        if (Player.item != "0000")
            DestroyFood();
    }

    public void GoBackClients()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Clientes");
        Player.item = "0000";
    }

    public void GoBackToppings()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        if (Player.item != "0000")
            DestroyFood();
    }
    public void DestroyFood()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(Player.item);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
