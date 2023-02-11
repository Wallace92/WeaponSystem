using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WeaponSystemScriptable
{
    public class WeaponSystemScriptable : MonoBehaviour
    {
        // private List<Damageable> Weapons;
        //
        // private int currentWeaponIndex = 0;
        // private void Awake() => Weapons = GetComponentsInChildren<Damageable>().ToList();
        //
        // public void Attack() => Weapons[currentWeaponIndex].Use();
        //
        // public void Update()
        // {
        //     if (Input.GetMouseButtonDown(0))
        //     {
        //         Attack();
        //     }
        //
        //     if (Input.GetMouseButtonDown(1))
        //     {
        //         currentWeaponIndex = (currentWeaponIndex + 1) % Weapons.Count;
        //     }
        // }
        
        [SerializeField]
        private Damageable m_selectedWeapon;
        
        [SerializeField]
        private WeaponRotator m_weaponRotator;
        
        [SerializeField]
        private WeaponSelector<Damageable> m_weaponSelector;
        
        private void Awake()
        {
            m_weaponRotator = new WeaponRotator();
            m_weaponSelector = new WeaponSelector<Damageable>(GetComponentsInChildren<Damageable>().ToList());
            
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