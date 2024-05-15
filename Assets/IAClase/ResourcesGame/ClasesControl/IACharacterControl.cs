using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    public Health health { get; set; }
    public VisionSensor visionSensor { get; set; }

    public virtual void LoadComponent()
    {
        health = GetComponent<Health>();
        visionSensor = GetComponent<VisionSensor>();
    }
}
