using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using WeaponSystemInheritance;

[Serializable]
public class WeaponSelector
{
    [SerializeField]
    private List<Weapon> Weapons;

    private int m_currentWeaponIndex = 0;

    public WeaponSelector(List<Weapon> weapons) => Weapons = weapons;


    public Weapon Next()
    {
        m_currentWeaponIndex = (m_currentWeaponIndex + 1) % Weapons.Count;
       
        return Weapons[m_currentWeaponIndex];
    }
    
    public Weapon First() => Weapons.First();
}