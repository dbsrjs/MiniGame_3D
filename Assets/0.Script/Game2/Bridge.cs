using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bridge : MonoBehaviour
{
    [SerializeField] private GameObject[] brige = new GameObject[] {};
    
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 100);
        bool a = rand < 50 ? true : false;

        if (a == false)
        {
            
        }
        /*
        int halfCount = brige.Length / 2;
        for (int i = 0; i < halfCount; i++)
        {
            BoxCollider boxCollider = brige[i].GetComponent<BoxCollider>();
            if (boxCollider != null)
            {
                Destroy(boxCollider);
            }
        }
        */
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
