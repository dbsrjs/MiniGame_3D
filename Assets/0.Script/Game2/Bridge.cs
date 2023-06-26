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
        int halfCount = brige.Length / 2;
        for (int i = 0; i < halfCount; i++)
        {
            BoxCollider boxCollider = brige[i].GetComponent<BoxCollider>();
            if (boxCollider != null)
            {
                boxCollider.isTrigger = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
