using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/View")]

public class ActionNodeNotViewLadron : ActionNodeView
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_iACharacterVehiculo.visionSensor.EnemyView == null)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
