using UnityEngine;

namespace WeaponSystemInheritance
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField]
        private int m_damage;

        [SerializeField]
        private string m_name;

        public int Damage
        {
            get => m_damage;
            set => m_damage = value;
        }

        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public abstract void Use();
    }
}