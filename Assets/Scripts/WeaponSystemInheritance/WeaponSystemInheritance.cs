using System.Linq;
using UnityEngine;

namespace WeaponSystemInheritance
{
    public class WeaponSystemInheritance : MonoBehaviour
    {
        [SerializeField]
        private Weapon m_selectedWeapon;
        
        [SerializeField]
        private WeaponRotator m_weaponRotator;
        
        [SerializeField]
        private WeaponSelector<Weapon> m_weaponSelector;
        
        private void Awake()
        {
            m_weaponRotator = new WeaponRotator();
            m_weaponSelector = new WeaponSelector<Weapon>(GetComponentsInChildren<Weapon>().ToList());
            
            m_selectedWeapon = m_weaponSelector.First();
        }

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
                Attack();

            if (Input.GetMouseButtonDown(1))
                m_selectedWeapon = m_weaponSelector.Next();

            m_weaponRotator.RotateObject(m_selectedWeapon.gameObject);
        }

        private void Attack() => m_selectedWeapon.Use();
    }
}