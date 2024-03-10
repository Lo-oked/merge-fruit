using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit_merge : MonoBehaviour
{
    [SerializeField] public Vector3 newFruitPos; 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            newFruitPos = Vector3.Lerp(collision.gameObject.transform.position, gameObject.transform.position, 0.5f);
            Fruit_Spawner.fruitmergeposition = newFruitPos;
            Fruit_Spawner.fruitspawn = true;
            Destroy(gameObject);
        }
    }
}
