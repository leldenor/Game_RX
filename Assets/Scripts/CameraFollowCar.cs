using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCar : MonoBehaviour
{
    public Transform car;

    void FixedUpdate()
    {
        Vector3 localOffset = car.transform.up * 3f - car.transform.forward * 6f;
        transform.position = car.transform.position + localOffset;
        transform.rotation = car.transform.rotation;
    }
}
