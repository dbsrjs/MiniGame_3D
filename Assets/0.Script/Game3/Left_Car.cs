using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Car : MonoBehaviour
{
    private float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.x == -16f)
        {
            Destroy(this.gameObject);
        }
    }
}
