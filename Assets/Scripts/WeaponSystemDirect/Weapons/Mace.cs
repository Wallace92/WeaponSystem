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
    public override void Use()
    {
        Debug.Log($"WhiteWeapon dealDamage {DamageModifier * Damage} by {Name}, because of DamageModifier {DamageModifier}");
    }
}