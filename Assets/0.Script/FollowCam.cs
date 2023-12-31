using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y + 2.5f;
        pos.z = target.position.z - 2f;

        transform.position = Vector3.Lerp(target.position, pos, 1f);
    }
}
