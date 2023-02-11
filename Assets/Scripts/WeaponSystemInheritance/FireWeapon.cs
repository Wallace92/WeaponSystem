using UnityEngine;

namespace WeaponSystemInheritance
{
    public class FireWeapon : Weapon
    {
        [SerializeField]
        private int m_ammunition;

        public int Ammunition
        {
            get => m_ammunition;
            set => m_ammunition = value;
        }

        public override void Use()
        {
            Debug.Log($"Ranged Weapon dealDamage {Damage} by {Name} with ammo {m_ammunition}");
        }
    }
}

