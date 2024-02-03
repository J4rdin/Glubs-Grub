using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjoFusion : MonoBehaviour
{
    public GameObject TacoOjoPrefab;

    private void OnCollisionEnter2D (Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "1000")
        {
            Instantiate(TacoOjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoOjo;
            print(Player.item);
        }
    }

}
