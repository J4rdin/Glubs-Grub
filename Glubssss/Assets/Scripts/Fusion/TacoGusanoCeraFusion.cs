using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoGusanoCeraFusion : MonoBehaviour
{
    public GameObject TacoGusanoCeraRoachPrefab;
    public GameObject TacoGusanoCeraUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoGusanoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoGusanoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosCeraUnas;
            print(Player.item);
        }
    }
}
