using UnityEngine;
using WeaponSystemScriptable;

public class MeleeWeaponInspector :  WeaponInspector, IDamageable
{
    public void Use() => Debug.Log("Melee weapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}