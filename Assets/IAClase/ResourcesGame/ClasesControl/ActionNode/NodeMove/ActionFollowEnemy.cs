using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Move")]

public class ActionFollowEnemy : ActionNodeVehicle
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_iACharacterVehiculo.health.IsDead)
            return TaskStatus.Failure;

        SwitchUnit();

        return TaskStatus.Success;

    }
    void SwitchUnit()
    {
        switch (_unitSC)
        {
            case unitSC.Police:
                if (_iACharacterVehiculo is IACharacterVehiculoLandPolice)
                {
                    ((IACharacterVehiculoLandPolice)_iACharacterVehiculo).MoveToEnemy();
                    ((IACharacterVehiculoLandPolice)_iACharacterVehiculo).LookEnemy();
                }
                break;
            case unitSC.Civil:
                break;
            case unitSC.Ladron:
                if (_iACharacterVehiculo is IACharacterVehiculoLandLadron)
                {
                    ((IACharacterVehiculoLandLadron)_iACharacterVehiculo).MoveToEnemy();
                    ((IACharacterVehiculoLandLadron)_iACharacterVehiculo).LookEnemy();
                }
                break;
            case unitSC.None:
                break;
            default:
                break;
        }
    }
}
