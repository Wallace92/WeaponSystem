using System;
using UnityEngine;

[Serializable]
public class Knife : WhiteWeapon
{
    public int SpeedModifier = 10;

    public Knife()
    {
        Name = "Knife";
        Damage = 10;
    }
    public override void Use() => 
        Debug.Log($"{Name}, dealt {Damage}, speed {SpeedModifier * Speed}");
}
