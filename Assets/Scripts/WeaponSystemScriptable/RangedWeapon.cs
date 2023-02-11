using UnityEngine;
using WeaponSystemScriptable.ScriptableObjects;

namespace WeaponSystemScriptable
{
    public class RangedWeapon : Damageable
    {
        [SerializeField] 
        private RangedWeaponScriptableObject m_weaponScriptableObject;
    
        [SerializeField]
        private int m_ammunition;

        public int Ammunition
        {
            get => m_ammunition;
            set => m_ammunition = value;
        }

        public override void Use()
        {
            Debug.Log($"Ranged Weapon dealDamage {m_weaponScriptableObject.Damage} by {m_weaponScriptableObject.Name} with ammo {Ammunition}");
        }
    }
}