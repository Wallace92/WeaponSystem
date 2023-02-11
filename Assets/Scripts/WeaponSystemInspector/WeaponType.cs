using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponType : MonoBehaviour
{
    public List<Weapon> AvailableWeapons;

    public int SelectedWeaponIndex { get;  set; }

    [SerializeField]
    private WeaponRotator m_weaponRotator;

    protected Weapon SelectedWeapon => AvailableWeapons[SelectedWeaponIndex];

    private void Awake() => m_weaponRotator = new WeaponRotator();

    private void Update() => m_weaponRotator.RotateObject(SelectedWeapon.gameObject);


    public abstract void Use();
}