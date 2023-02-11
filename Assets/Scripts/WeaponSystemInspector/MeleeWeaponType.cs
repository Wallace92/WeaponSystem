using UnityEngine;

public class MeleeWeaponType :  WeaponType
{
    public override void Use() => Debug.Log("Melee weapon: " + SelectedWeapon.Name + " with damage " + SelectedWeapon.Damage);
}