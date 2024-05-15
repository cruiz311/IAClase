using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum unitSC
{
    Police,
    Civil,
    Ladron,
}
public class Health : MonoBehaviour 
{
    public int sleep = 100;
    public int hunger = 100;
    public int wc = 0;

    [Header("CountHealth")]
    public int health;
    public int healthMax = 100;
    public bool IsDead { get => (health <= 0); }

    [Header("AimOffSet")]
    public Transform AimOffset;

    public unitSC unitSC;
    public unitSC[] unitSCAllies;
    public virtual void LoadComponent()
    {
        health = healthMax;
    }
}
