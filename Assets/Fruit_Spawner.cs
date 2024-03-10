using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit_Spawner : MonoBehaviour
{
    public List<GameObject> Fruits;
    public static bool fruitspawn;
    public static Vector3 fruitmergeposition;
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(Fruits[0], new Vector3(mousePosition.x,gameObject.transform.position.y,0), Quaternion.identity);
        }
        fruit_merge();
    }

    void fruit_merge()
    {
        if (fruitspawn == true)
        {
            fruitspawn = false;
            Instantiate(Fruits[0], fruitmergeposition, Quaternion.identity);
        }
    }
}
