using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeAgent { A, B, C, D, E }
public enum unitSC
{
    Zombie,
    Soldier,
    Civil,
    None
}
public class Health : MonoBehaviour
{
    public int sleep = 100;
    public int hunger = 100;
    public int wc = 0;

    public unitSC unitSC;
    public Transform AimOffset;
}
