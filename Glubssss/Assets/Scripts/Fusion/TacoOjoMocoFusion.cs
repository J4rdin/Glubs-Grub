using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoOjoMocoFusion : MonoBehaviour
{
    public GameObject TacoOjoMocoRoachPrefab;
    public GameObject TacoOjoMocoUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoMocoUnas;
            print(Player.item);
        }
    }
}
