using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFoodSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TacoPrefab;
    public GameObject OjoPrefab;
    public GameObject TacoOjoPrefab;
    public GameObject TacoOjoMocoPrefab;
    public GameObject TacoOjoMocoRoachPrefab;
    public GameObject TacoOjoMocoUnasPrefab;
    public GameObject TacoGusanosPrefab;
    public GameObject TacoGusanosMocoPrefab;
    public GameObject TacoGusanosMocoRoachPrefab;
    public GameObject TacoGusanosMocoUnasPrefab;
    public GameObject TacoGusanosCeraPrefab;
    public GameObject TacoGusanosCeraRoachPrefab;
    public GameObject TacoGusanosCeraUnasPrefab;
    public GameObject TacoOjoCeraPrefab;
    public GameObject TacoOjoCeraRoachPrefab;
    public GameObject TacoOjoCeraUnasPrefab;

    void Start()
    {
        if (Player.item == FoodID.PanTaco)
        {
            Instantiate(TacoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.Ojo)
        {
            Instantiate(OjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjo)
        {
            Instantiate(TacoOjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMoco)
        {
            Instantiate(TacoOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCera)
        {
            Instantiate(TacoOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMocoRoach)
        {
            Instantiate(TacoOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMocoUnas)
        {
            Instantiate(TacoOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCeraRoach)
        {
            Instantiate(TacoOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCeraUnas)
        {
            Instantiate(TacoOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanos)
        {
            Instantiate(TacoGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMoco)
        {
            Instantiate(TacoGusanosMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCera)
        {
            Instantiate(TacoGusanosCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMocoRoach)
        {
            Instantiate(TacoGusanosMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMocoUnas)
        {
            Instantiate(TacoGusanosMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCeraRoach)
        {
            Instantiate(TacoGusanosCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCeraUnas)
        {
            Instantiate(TacoGusanosCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
