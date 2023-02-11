using UnityEngine;

public abstract class WeaponSystemBase<T> : WeaponSystemSelector<T> where T : MonoBehaviour
{
    [SerializeField]
    private WeaponRotator m_weaponRotator;

    protected new void Awake()
    {
        base.Awake();
        m_weaponRotator = new WeaponRotator();
    }

    public new void Update()
    {
        base.Update();
        m_weaponRotator.RotateObject(m_selectedWeapon.gameObject);
    }
}