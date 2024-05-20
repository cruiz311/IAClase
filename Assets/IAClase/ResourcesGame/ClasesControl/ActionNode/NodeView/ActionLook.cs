using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("MyAI/View")]

public class ActionLook : ActionNodeView
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
                    ((IACharacterVehiculoLandPolice)_iACharacterVehiculo).LookAnyDirection();
                }
                break;
            case unitSC.Civil:
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

