using UnityEngine;
using WeaponSystemScriptable.ScriptableObjects;

namespace WeaponSystemScriptable
{
    public class RangedWeapon : Damageable
    {
        [SerializeField] 
        private RangedWeaponScriptableObject m_weapon;
    
        [SerializeField]
        private int m_ammunition;

        public int Ammunition
        {
            get => m_ammunition;
            set => m_ammunition = value;
        }

        public override void Use()
        {
            Debug.Log($"{m_weapon.Name} dealDamage {m_weapon.Damage} with ammo {Ammunition}");
        }
    }
}