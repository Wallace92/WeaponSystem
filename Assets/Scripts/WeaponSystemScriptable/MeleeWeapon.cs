using UnityEngine;
using WeaponSystemScriptable.ScriptableObjects;

namespace WeaponSystemScriptable
{
    public class MeleeWeapon : MonoBehaviour, IDamageable
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
    
        public void Use()
        {
            Debug.Log($"WhiteWeapon dealDamage {m_weapon.Damage} by {m_weapon.Name} with speed {Speed}");
        }
    }
}