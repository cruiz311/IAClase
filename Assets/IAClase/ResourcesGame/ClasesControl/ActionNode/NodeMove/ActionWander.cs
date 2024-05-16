using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using Unity.VisualScripting;

[TaskCategory("MyAI/Move")]
public class ActionWander : ActionNodeVehicle
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
                    ((IACharacterVehiculoLandPolice)_iACharacterVehiculo).MoveToWander();

                }
                break;
            case unitSC.Civil:
                if (_iACharacterVehiculo is IACharacterVehiculoLandCivil)
                {
                    ((IACharacterVehiculoLandCivil)_iACharacterVehiculo).MoveToWander();

                }
                break;
            case unitSC.Ladron:
                if (_iACharacterVehiculo is IACharacterVehiculoLandLadron)
                {
                    ((IACharacterVehiculoLandLadron)_iACharacterVehiculo).MoveToWander();

                }
                break;
            case unitSC.None:
                break;
            default:
                break;
        }
    }
}
