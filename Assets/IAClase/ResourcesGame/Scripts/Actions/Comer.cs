using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comer : State
{
    void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void Execute()
    {
        if (FrameRate > arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;
            m_health.hunger = Mathf.Clamp(m_health.hunger + Random.Range(2, 10), 0, 100);
            if (m_health.hunger == 100)
                m_MachineState.NextState(TypeState.Jugar);
            m_health.sleep = Mathf.Clamp(m_health.sleep - Random.Range(2, 10), 0, 100);
            if (m_health.sleep == 0)
                m_MachineState.NextState(TypeState.Dormir);
            m_health.wc = Mathf.Clamp(m_health.wc + Random.Range(5, 10), 0, 100);
            if (m_health.wc == 100)
                m_MachineState.NextState(TypeState.Banno);
            return;
        }
        FrameRate += Time.deltaTime;
    }
    public override void Exit()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Execute();
    }
}
