using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    public InputManager manager;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 20000f;
    public float maxTurn = 20f;

    private void Start()
    {
        manager = GetComponent<InputManager>();
    }
    private void Update()
    {
        foreach (WheelCollider wheelCollider in throttleWheels)
        {
            wheelCollider.motorTorque = strengthCoefficient * Time.deltaTime * manager.throttle;
        }
        foreach (WheelCollider wheelCollider in steeringWheels)
        {
            wheelCollider.steerAngle = maxTurn * manager.steer;
        }
    }
}
