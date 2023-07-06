using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Car : MonoBehaviour
{
    private float speed = 10f;

    private Car car;
    private FollowCam_Game3 cam;

    private void Start()
    {
        car = GameObject.Find("[ Car_Controller(L) ]").GetComponent<Car>();
        cam = GameObject.Find("Main Camera").GetComponent<FollowCam_Game3>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x >= 8f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(car.player);
        Destroy(cam);
    }
}
