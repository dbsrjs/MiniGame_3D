using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Cont : MonoBehaviour
{
    [SerializeField] List<Wood> trans;

    float spawnTime;
    float Timer;

    float speedCount = 5f;

    int nextCount = 1;
    int count = 0;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWood", 1f, speed);
    }

    void SpawnWood()
    {
        Wood wood = Instantiate(trans[Random.Range(0, trans.Count)], transform);
        wood.speed = speedCount++;
        count++;
        if (count >= nextCount)
        {
            CancelInvoke("SpawnWood");
            count = 0;
            nextCount = Random.Range(3, 6);
            speed = speed--;
            if(speed <= 0)
            {
                speed = 0.2f;
            }
            InvokeRepeating("SpawnWood", 3f, speed);
        }
    }
}
