using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab;
    [SerializeField] private Transform[] parent;

    float time = 0.0f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab[Random.Range(0, 6)], parent[Random.Range(0, 3)]);    //시작할 때 생성
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1.5f)
        {
            Instantiate(prefab[Random.Range(0, 6)], parent[Random.Range(0, 3)]);    //2초 마다 생성
            time = 0f;
        }
    }
}
