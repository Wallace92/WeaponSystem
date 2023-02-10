using UnityEngine;
using WeaponSystemScriptable;

public class RangedWeaponInspector : WeaponInspector, IDamageable
{
    public void Use() => Debug.Log("RangedWeapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}