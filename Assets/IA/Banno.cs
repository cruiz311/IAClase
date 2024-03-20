using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banno : State
{

    // Start is called before the first frame update
    float FrameRate;
    [SerializeField]
    float[] arrayTime = new float[10];
    [SerializeField]
    int index = 0;
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    void RandeArray()
    {
        for (int i = 0; i < arrayTime.Length; i++)
        {
            arrayTime[i] = UnityEngine.Random.Range(4, 10);
        }
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    // Update is called once per frame
    void Update()
    {
        if (FrameRate > arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;

            m_MachineState.NextState(TypeState.Jugar);
        }
        FrameRate += Time.deltaTime;
    }
}
