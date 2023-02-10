using UnityEngine;

public interface IWeapon
{
    string Name { get; set; }
    int Damage { get; set; }
    void Use();
}

public abstract class Weapon : MonoBehaviour, IWeapon
{
    [SerializeField]
    private int m_damage;

    [SerializeField]
    private string m_name;

    public int Damage
    {
        get => m_damage;
        set => m_damage = value;
    }

    public string Name
    {
        get => m_name;
        set => m_name = value;
    }

    public abstract void Use();
}



