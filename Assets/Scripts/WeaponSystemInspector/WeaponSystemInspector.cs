using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WeaponSystemInspector
{
    public class WeaponSystemInspector : MonoBehaviour 
    {
        [SerializeField]
        private WeaponInspector m_selectedWeapon;
        
        [SerializeField]
        private WeaponRotator m_weaponRotator;
        
        [SerializeField]
        private WeaponSelector<WeaponInspector> m_weaponSelector;
        
        private void Awake()
        {
            m_weaponRotator = new WeaponRotator();
            m_weaponSelector = new WeaponSelector<WeaponInspector>(GetComponentsInChildren<WeaponInspector>().ToList());
            
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