using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoOjoCeraFusion : MonoBehaviour
{
    public GameObject TacoOjoCeraRoachPrefab;
    public GameObject TacoOjoCeraUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjoCeraUnas;
            print(Player.item);
        }
    }
}
