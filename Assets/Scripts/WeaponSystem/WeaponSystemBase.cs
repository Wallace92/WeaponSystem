using System.Linq;
using UnityEngine;

public abstract class WeaponSystemBase<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private WeaponRotator m_weaponRotator;
    
    [SerializeField]
    private WeaponSelector<T> m_weaponSelector;
    
    protected T m_selectedWeapon;

    protected virtual void Awake()
    {
        m_weaponRotator = new WeaponRotator();
        m_weaponSelector = new WeaponSelector<T>(GetComponentsInChildren<T>().ToList());
        
        m_selectedWeapon = m_weaponSelector.First();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Attack();

        if (Input.GetMouseButtonDown(1))
            m_selectedWeapon = m_weaponSelector.Next();

        m_weaponRotator.RotateObject(m_selectedWeapon.gameObject);
    }

    protected abstract void Attack();
}