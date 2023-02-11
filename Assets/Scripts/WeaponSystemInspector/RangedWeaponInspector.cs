using UnityEngine;

public class RangedWeaponInspector : WeaponInspector
{
    public override void Use() => Debug.Log("RangedWeapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}