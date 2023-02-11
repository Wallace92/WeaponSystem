using System;
using UnityEngine;

[Serializable]
public class Mace : WhiteWeapon
{
    public int DamageModifier = 2;

    public Mace()
    {
        Name = "Mace";
        Damage = 25;
    }
    public override void Use() => 
        Debug.Log($"{Name} dealDamage {DamageModifier * Damage}, damageModifier {DamageModifier}");
}
