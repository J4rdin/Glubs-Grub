using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class WorkStation : MonoBehaviour
{
    public string SceneChoice;
    public GameObject popupPrefab;
    public GameObject TacoPrefab;
    public GameObject OjoPrefab;
    [SerializeField]
    private bool isNearObject = false;
    public string targetTag = "popup";
    public static bool entered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision detected with tag: " + other.tag);
        if (other.CompareTag("clients"))
        {
            if(Puddlespawn.hasmop==false)
            {
                Instantiate(popupPrefab);
                isNearObject = true;
                SceneChoice = "Clientes";
            }
        }
        if (other.CompareTag("meat"))
        {
            if (Puddlespawn.hasmop == false)
            {
                Instantiate(popupPrefab);
                isNearObject = true;
                SceneChoice = "Meat";
            }
        }
        if (other.CompareTag("bread"))
        {
            if (Puddlespawn.hasmop == false)
            {
                Instantiate(popupPrefab);
                isNearObject = true;
                SceneChoice = "Bread";
            }
        }
        if (other.CompareTag("toppings"))
        {
            if (Puddlespawn.hasmop == false)
            {
                Instantiate(popupPrefab);
                isNearObject = true;
                SceneChoice = "ToppingsYSalsas";
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("clients"))
        {
            DestroyObjectsWithTag();
            isNearObject = false;
        }
        if (other.CompareTag("meat"))
        {
            DestroyObjectsWithTag();
            isNearObject = false;
        }
        if (other.CompareTag("bread"))
        {
            DestroyObjectsWithTag();
            isNearObject = false;
        }
        if (other.CompareTag("toppings"))
        {
            DestroyObjectsWithTag();
            isNearObject = false;
        }
    }

    private void EnterScene(string Scene)
    {
        if(isNearObject == true && entered == false && Puddlespawn.hasmop == false && Input.GetKeyDown(KeyCode.E)) 
        {
            entered = true;
            Debug.Log("I hear ya brother");
            DestroyObjectsWithTag();
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
        }
    }

    public void DestroyObjectsWithTag()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }

    private void Update()
    {
        EnterScene(SceneChoice);
    }

}