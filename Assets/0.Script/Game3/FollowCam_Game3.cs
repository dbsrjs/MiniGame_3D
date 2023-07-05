using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam_Game3 : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y + 5f;
        pos.z = target.position.z - 5f;

        transform.position = Vector3.Lerp(target.position, pos, 1f);
    }
}
