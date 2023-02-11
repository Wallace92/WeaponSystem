using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class WeaponSelector<T>
{
    [SerializeField]
    private List<T> Weapons;
    
    private int m_currentWeaponIndex = 0;
    
    public WeaponSelector(List<T> weapons) => Weapons = weapons;

    public T Next()
    {
        m_currentWeaponIndex = (m_currentWeaponIndex + 1) % Weapons.Count;
       
        return Weapons[m_currentWeaponIndex];
    }
    
    public T First() => Weapons.First();
}