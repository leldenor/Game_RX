using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    [SerializeField] WheelCollider Front_Left_Wheel_Component;
    [SerializeField] WheelCollider Front_Right_Wheel_Component;
    [SerializeField] WheelCollider Back_Left_Wheel_Component;
    [SerializeField] WheelCollider Back_Right_Wheel_Component;


    public float acceleration = 500f;
    public float breakForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentSpeed = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        currentSpeed = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
           currentBreakForce = breakForce;
        else
           currentBreakForce = 0f;


        Front_Right_Wheel_Component.motorTorque = currentSpeed;
        Front_Left_Wheel_Component.motorTorque = currentSpeed;

        Front_Right_Wheel_Component.brakeTorque = currentBreakForce;
        Front_Left_Wheel_Component.brakeTorque = currentBreakForce;
        Back_Left_Wheel_Component.brakeTorque = currentBreakForce;
        Back_Right_Wheel_Component.brakeTorque = currentBreakForce;

        // Take care of the steering
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        Front_Left_Wheel_Component.steerAngle = currentTurnAngle;
        Front_Right_Wheel_Component.steerAngle = currentTurnAngle;

    }

}
