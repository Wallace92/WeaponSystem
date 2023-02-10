using System;
using UnityEngine;

namespace WeaponSystemInheritance.Weapons
{
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
}