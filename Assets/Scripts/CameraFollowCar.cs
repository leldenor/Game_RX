using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCar : MonoBehaviour
{
    public Transform car;
    Vector3 offSet;
    public float z;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 localOffset = car.transform.up * 3f - car.transform.forward * 6f;
        transform.position = car.transform.position + localOffset;
        transform.rotation = car.transform.rotation;
        /*Vector3 camPos = car.position + offSet;
        camPos.z = camPos.z - z;
        transform.position = Vector3.Lerp(transform.position, camPos, smoothing * Time.deltaTime);*/

    }
}
