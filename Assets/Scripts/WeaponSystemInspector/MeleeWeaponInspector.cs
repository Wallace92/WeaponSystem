using UnityEngine;

public class MeleeWeaponInspector :  WeaponInspector
{
    public override void Use() => Debug.Log("Melee weapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}