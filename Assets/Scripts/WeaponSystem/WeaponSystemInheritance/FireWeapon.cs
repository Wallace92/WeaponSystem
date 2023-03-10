using UnityEngine;

public class FireWeapon : Weapon
{
    [SerializeField]
    private int m_ammunition;

    public int Ammunition
    {
        get => m_ammunition;
        set => m_ammunition = value;
    }

    public override void Use() => 
        Debug.Log($"Ranged weapon {Name} deal {Damage} Damage, ammo {Ammunition}");
}


