using System;
using UnityEngine;

namespace WeaponSystemInheritance
{
    [Serializable]
    public class WhiteWeapon : Weapon
    {

        [SerializeField]
        private int m_speed;

        public int Speed
        {
            get => m_speed;
            set => m_speed = value;
        }

        public override void Use()
        {
            Debug.Log($"WhiteWeapon dealDamage {Damage} by {Name} with speed {Speed}");
        }
    }
}

