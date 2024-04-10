using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormir : State
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

            m_health.sleep = Mathf.Clamp(m_health.sleep + Random.Range(2, 10), 0, 100);
            if (m_health.sleep == 100)
                m_MachineState.NextState(TypeState.Jugar);

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
