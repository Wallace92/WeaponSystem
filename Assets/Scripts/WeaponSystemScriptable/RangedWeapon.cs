using UnityEngine;
using WeaponSystemScriptable.ScriptableObjects;

namespace WeaponSystemScriptable
{
    public class RangedWeapon : MonoBehaviour,  IDamageable
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

        public void Use()
        {
            Debug.Log($"Ranged Weapon dealDamage {m_weaponScriptableObject.Damage} by {m_weaponScriptableObject.Name} with ammo {m_ammunition}");
        }
    }
}