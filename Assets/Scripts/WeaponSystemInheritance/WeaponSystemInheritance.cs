using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WeaponSystemInheritance
{
    public class WeaponSystemInheritance : MonoBehaviour
    {
        [SerializeField]
        private List<IWeapon> Weapons;
    
        private int currentWeaponIndex = 0;
        private void Awake() => Weapons = GetComponentsInChildren<IWeapon>().ToList();

        public void Attack() => Weapons[currentWeaponIndex].Use();

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }

            if (Input.GetMouseButtonDown(1))
            {
                currentWeaponIndex = (currentWeaponIndex + 1) % Weapons.Count;
            }
        }
    }
}