using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game5Enemy : MonoBehaviour
{
    [SerializeField] private Player p;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(p.transform);
    }
}
