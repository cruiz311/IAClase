using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/Move")]
public class ActionEvadeEnemy : ActionNodeVehicle
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_iACharacterVehiculo.health.IsDead)
            return TaskStatus.Failure;

        SwitchUnit();

        return TaskStatus.Success;

    }
    void SwitchUnit()
    {
        switch (_unitSC)
        {
            case unitSC.Police:
                break;
            case unitSC.Civil:
                if(_iACharacterVehiculo is IACharacterVehiculoLandCivil)
                {
                    ((IACharacterVehiculoLandCivil)_iACharacterVehiculo).MoveToEvadEnemy();
                }
                break;
            case unitSC.Ladron:
                break;
            case unitSC.None:
                break;
            default:
                break;
        }
    }
}