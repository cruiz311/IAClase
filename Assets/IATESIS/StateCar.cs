using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeStateCar {Comer,Jugar,Banno,Dormir};
public class StateCar : MonoBehaviour
{
    public TypeState type;
    public MachineStateCar m_MachineState;
    public virtual void LoadComponent()
    {
        m_MachineState = GetComponent<MachineStateCar>();
    }
    public virtual void Enter( )
    {

    }
    public virtual void Execute()
    {

    }
    public virtual void Exit()
    {

    }
}
