using System;
using UnityEngine;

[Serializable]
public class WhiteWeapon : Weapon
{
    private int m_speed = 1;
    public int Speed
    {
        get => m_speed;
        set => m_speed = value;
    }

    public override void Use() => 
        Debug.Log($"WhiteWeapon {Name} dealDamage {Damage}, speed {Speed}");
}


