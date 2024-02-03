using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoGusanoFusion : MonoBehaviour
{
    public GameObject TacoGusanoMocoPrefab;
    public GameObject TacoGusanoCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(TacoGusanoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(TacoGusanoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosCera;
            print(Player.item);
        }
    }

}
