using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class IACharacterControl : MonoBehaviour
{
    public Health health;

    public virtual void LoadComponent()
    {

    }
}
