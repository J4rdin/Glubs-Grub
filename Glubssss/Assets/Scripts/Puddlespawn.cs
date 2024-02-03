using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddlespawn : MonoBehaviour
{
    public GameObject PuddlePrefab;
    public float Timer = 2f;
    public float TimerDur = 2f;
    public static bool hasmop = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Puddle" && hasmop == true)
        {
            DestroyPuddle();
            Timer = TimerDur;
        }

        if (other.gameObject.tag == "Mop")
        {
            if (!hasmop)
                hasmop = true;
            else
                hasmop = false;
        }
    }

        void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            DestroyPuddle();
            Instantiate(PuddlePrefab, new Vector3(-1.329f, -3.777f, 0f), transform.rotation);
            Timer = TimerDur;
        }
    }

    public void DestroyPuddle()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag("Puddle");

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
