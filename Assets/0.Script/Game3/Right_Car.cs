using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Car : MonoBehaviour
{
    private float speed = 3f;

    private Car car;
    private FollowCam_Game3 cam;

    private void Start()
    {
        car = GameObject.Find("[ Car_Controller ]").GetComponent<Car>();
        cam = GameObject.Find("Main Camera").GetComponent<FollowCam_Game3>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x <= -9f)
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
