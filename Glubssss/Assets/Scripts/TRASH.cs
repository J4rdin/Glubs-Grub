using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRASH : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Player.item = "0000";
    }
}
