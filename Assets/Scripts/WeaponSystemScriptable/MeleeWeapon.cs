using UnityEngine;
using WeaponSystemScriptable.ScriptableObjects;

namespace WeaponSystemScriptable
{
    public class MeleeWeapon : Damageable
    {
        [SerializeField] 
        private MeleeWeaponScriptableObject m_weapon;
   
        [SerializeField]
        private int m_speed;

        public int Speed
        {
            get => m_speed;
            set => m_speed = value;
        }
    
        public override void Use()
        {
            Debug.Log($"{m_weapon.Name} dealDamage {m_weapon.Damage} with speed {Speed}");
        }
    }
}