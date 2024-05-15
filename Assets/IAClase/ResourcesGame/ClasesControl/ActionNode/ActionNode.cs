using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/NODE BASE")]
public class ActionNode : Action
{

    protected IACharacterVehiculo _iACharacterVehiculo;
    protected IACharacterAction _iACharacterAction;
    protected unitSC unitSC;

    public override void OnStart()
    {
        _iACharacterVehiculo = GetComponent<IACharacterVehiculo>();
        if(_iACharacterVehiculo == null)
            Debug.LogWarning("NOT LOAD COMPONENT AICHARACTER VEHICULO");
        _iACharacterAction = GetComponent<IACharacterAction>();
        if (_iACharacterAction == null)
            Debug.LogWarning("NOT LOAD COMPONENT AICHARACTER ACTION");

        if(_iACharacterVehiculo != null)
        {
            unitSC = this._iACharacterVehiculo.health.unitSC;
        }
        else if (_iACharacterAction != null)
        {
            unitSC = this._iACharacterAction.health.unitSC;
        }

        base.OnStart();
    }
}
