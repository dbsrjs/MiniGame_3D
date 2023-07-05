using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Car : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab;
    [SerializeField] private Transform[] parent;

    float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab[Random.Range(0, 3)], parent[Random.Range(0, 3)]);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= 2f)
        {
            Instantiate(prefab[Random.Range(0, 3)], parent[Random.Range(0, 3)]);
            time = 0f;
        }

        
    }
}
