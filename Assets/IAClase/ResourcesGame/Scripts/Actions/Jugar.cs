using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugar : State
{
    void Start()
    {
        RandeArray();
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

            m_health.hunger = Mathf.Clamp(m_health.hunger - Random.Range(2, 10), 0, 100);
            if (m_health.hunger == 0)
                m_MachineState.NextState(TypeState.Comer);

            m_health.sleep = Mathf.Clamp(m_health.sleep - Random.Range(2, 10), 0, 100);
            if (m_health.sleep == 0)
                m_MachineState.NextState(TypeState.Dormir);

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
