using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponType : MonoBehaviour
{
    public List<Weapon> AvailableWeapons;

    [SerializeField]
    private WeaponRotator m_weaponRotator;
    
    [HideInInspector]
    public Weapon SelectedWeapon;

    public abstract void Use();
    private void Awake()
    {
        m_weaponRotator = new WeaponRotator();
    }

    private void Update()
    {
        if (SelectedWeapon == null)
            return;
        
        m_weaponRotator.RotateObject(SelectedWeapon.gameObject);
    }
}