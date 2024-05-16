using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    public NavMeshAgent agent { get; set; }
    public Health health { get; set; }
    public VisionSensor visionSensor { get; set; }

    public virtual void LoadComponent()
    {
        agent = GetComponent<NavMeshAgent>();
        health = GetComponent<Health>();
        visionSensor = GetComponent<VisionSensor>();
    }
}
