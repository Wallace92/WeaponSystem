using UnityEngine;

public class RangedWeaponType : WeaponType
{
    public override void Use() => 
        Debug.Log("RangedWeapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}