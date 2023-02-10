using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WeaponSystemScriptable
{
    public class WeaponSystemScriptable : MonoBehaviour
    {
        private List<IDamageable> Weapons;
    
        private int currentWeaponIndex = 0;
        private void Awake() => Weapons = GetComponentsInChildren<IDamageable>().ToList();

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