using System.Linq;
using UnityEngine;

public abstract class WeaponSystemSelector<T> : MonoBehaviour
{
    [SerializeField]
    protected T m_selectedWeapon;
    
    [SerializeField]
    private WeaponSelector<T> m_weaponSelector;
    
    public void Awake()
    {
        m_weaponSelector = new WeaponSelector<T>(GetComponentsInChildren<T>().ToList());
            
        m_selectedWeapon = m_weaponSelector.First();
    }
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Attack();

        if (Input.GetMouseButtonDown(1))
            m_selectedWeapon = m_weaponSelector.Next();
    }
    
    protected abstract void Attack();
}