using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeState { Comer,Jugar,Banno,Dormir}
public class State : MonoBehaviour
{
    public TypeState type;
    public MachineState m_MachineState;
    protected Health m_health; 
    public float FrameRate;
    [SerializeField]
    protected float[] arrayTime = new float[10];
    [SerializeField]
    protected int index = 0;

    public void RandeArray()
    {
        for(int i = 0; i<arrayTime.Length; i++)
        {
            arrayTime[i] = Random.Range(2, 4);
        }
    }
    public virtual void LoadComponent()
    {
        m_MachineState = GetComponent<MachineState>();
        m_health = GetComponent<Health>();

    }
    public virtual void Enter( )
    {

    }
    public virtual void Execute()
    {
        m_health.sleep -= Mathf.Clamp(Random.Range(20, 30), 0, 100);
        m_health.hunger -= Mathf.Clamp(Random.Range(20, 30), 0, 100);
    }
    public virtual void Exit()
    {

    }
}
