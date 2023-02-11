using System.Linq;
using UnityEngine;

namespace WeaponSystemInspector
{
    public class WeaponSystemInspector : MonoBehaviour 
    {
        [SerializeField]
        private WeaponType m_selectedWeaponType;

        [SerializeField]
        private WeaponSelector<WeaponType> m_weaponSelector;
        
        private void Awake()
        {
            m_weaponSelector = new WeaponSelector<WeaponType>(GetComponentsInChildren<WeaponType>().ToList());
            
            m_selectedWeaponType = m_weaponSelector.First();
        }

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
                Attack();

            if (Input.GetMouseButtonDown(1))
                m_selectedWeaponType = m_weaponSelector.Next();
        }

        private void Attack() => m_selectedWeaponType.Use();
    }
}