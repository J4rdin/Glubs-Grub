using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoOjoFusion : MonoBehaviour
{
    public GameObject TacoOjoMocoPrefab;
    public GameObject TacoOjoCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(TacoOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(TacoOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoCera;
            print(Player.item);
        }
    }

}
