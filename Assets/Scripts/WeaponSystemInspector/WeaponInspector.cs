using System.Collections.Generic;
using UnityEngine;
using WeaponSystemInheritance;

public abstract class WeaponInspector : MonoBehaviour
{
    public List<Weapon> AvailableWeapons = new List<Weapon>();
    
    [HideInInspector] 
    public int SelectedWeaponIndex;

    protected Weapon SelectedWeapon => AvailableWeapons[SelectedWeaponIndex];

    public abstract void Use();
}